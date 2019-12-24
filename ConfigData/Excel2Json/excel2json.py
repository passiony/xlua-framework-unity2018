#-*- coding:utf-8 -*-

import sys
import os
import xlrd
import re

# 使可以解析中文字符
reload(sys)
sys.setdefaultencoding('utf8')

# 当前脚本路径
curpath = os.path.dirname(os.path.abspath(sys.argv[0]))


# 文件头描述格式化文本
lua_file_head_format_desc = '''/*

        %s
        exported by excel2json.py
        from file:%s

*/\n\n'''

# 将数据导出到tgt_lua_path
def excel2lua(src_excel_path, tgt_lua_path):
    print('[file] %s -> %s' % (src_excel_path, tgt_lua_path))
    # load excel data
    excel_data_src = xlrd.open_workbook(src_excel_path, encoding_override = 'utf-8')
    print('[excel] Worksheet names : %s'%excel_data_src.sheet_names())

    # get first Sheet
    excel_sheet = excel_data_src.sheet_by_index(0)
    print('[excel] parse sheet: %s (%d row, %d col)' % (excel_sheet.name, excel_sheet.nrows, excel_sheet.ncols))

    # excel data dict
    excel_data_dict = {}

    # col name list
    col_name_list = []

    #col val type list
    col_val_type_list = []

    # ctype: 0 empty, 1 string, 2 number, 3 date, 4 boolean, 5 error

    # 第一行是表名
    # 第二行是所有列的描述

    # 遍历第三行的所有列 保存字段名
    for col in range(0, excel_sheet.ncols):
        cell = excel_sheet.cell(2, col)
        col_name_list.append(str(cell.value))
        assert cell.ctype == 1, "found a invalid col name in col [%d] !~" % (col)

    # 遍历第四行的所有列 保存数据类型
    for col in range(0, excel_sheet.ncols):
        cell = excel_sheet.cell(3, col)
        col_val_type_list.append(str(cell.value))
        assert cell.ctype == 1, "found a invalid col val type in col [%d] !~" % (col)

    # 剔除表头、字段名和字段类型所在行
    # 从第五行开始遍历 构造行数据
    for row in range(4, excel_sheet.nrows):
        # 保存数据索引 默认第一列为id
        cell_id = excel_sheet.cell(row, 0)

        assert cell_id.ctype == 2, "found a invalid id in row [%d] !~" % (row)

        # 检查id的唯一性
        if cell_id.value in excel_data_dict:
            print('[warning] duplicated data id: "%d", all previous value will be ignored!~' % (cell_id.value))

        # row data list
        row_data_list = []

        # 保存每一行的所有数据
        for col in range(0, excel_sheet.ncols):
            cell = excel_sheet.cell(row, col)
            k = col_name_list[col]
            cell_val_type = col_val_type_list[col]

            # ignored the string that start with '_'
            if str(k).startswith('_'):
                continue

            # 根据字段类型去调整数值 如果为空值 依据字段类型 填上默认值
            if cell_val_type == 'string':
                if cell.ctype == 0:
                    v = '\"\"'
                else:
                    v = '\"%s\"' % (cell.value)
            elif cell_val_type == 'int':
                if cell.ctype == 0:
                    v = 0
                else:
                    v = int(cell.value)
            elif cell_val_type == 'float':
                if cell.ctype == 0:
                    v = 0
                else:
                    v = float(cell.value)
            elif cell_val_type == 'bool':
                if cell.ctype == 0:
                    v = 'false'
                else:
                    v = cell.value
            elif cell_val_type == 'table':
                if cell.ctype == 0:
                    v = '{}'
                else:
                    v = cell.value
            else:
                v = cell.value

            # 加入列表
            row_data_list.append([k, v])

        # 保存id 和 row data
        excel_data_dict[cell_id.value] = row_data_list

    # 正则搜索lua文件名 不带后缀 用作table的名称 练习正则的使用
    searchObj = re.search(r'([^\\/:*?"<>|\r\n]+)\.\w+$', tgt_lua_path, re.M|re.I)
    lua_table_name = searchObj.group(1)
    # print('正则匹配:', lua_table_name, searchObj.group(), searchObj.groups())

    # 这个就直接获取文件名了
    src_excel_file_name = os.path.basename(src_excel_path)
    tgt_lua_file_name = os.path.basename(tgt_lua_path)

    # file head desc
    lua_file_head_desc = lua_file_head_format_desc % (tgt_lua_file_name, src_excel_file_name)

    # export to lua file
    lua_export_file = open(tgt_lua_path, 'w')
    lua_export_file.write(lua_file_head_desc)
    lua_export_file.write('%s = {\n' % lua_table_name)

    # 遍历excel数据字典 按格式写入
    for k, v in excel_data_dict.items():
        lua_export_file.write('    \"%d\" : {\n' % k)
        for row_data in v:
            lua_export_file.write('        \"{0}\" : {1},\n'.format(row_data[0], row_data[1]))
        lua_export_file.write('    },\n')

    lua_export_file.write('}\n')

    lua_export_file.close()

    print('[excel] %d row data exported!~' % (excel_sheet.nrows))

# Make a script both importable and executable (∩_∩)
if __name__ == '__main__':
    if len(sys.argv) < 3:
        print('python excel2lua.py <excel_input_path> <lua_output_path>')
        exit(1)

    excel2lua(os.path.join(curpath, sys.argv[1]), os.path.join(curpath, sys.argv[2]))
    
    # excelPath = curpath+"/Hero.xlsx";
    # luaPath = curpath+"/Hero.lua";
    # excel2lua(excelPath, luaPath)

    exit(0)
