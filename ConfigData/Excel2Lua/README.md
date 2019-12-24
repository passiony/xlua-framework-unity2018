## 新手必读

## 环境配置

- 1.安装Python环境
	下载python2.7.exe,手动安装

- 2.安装pip
	```
	$ curl https://bootstrap.pypa.io/get-pip.py -o get-pip.py   # 下载安装脚本
	$ sudo python get-pip.py    # 运行安装脚本
	$ pip --version # 查看pip版本，是否安装成功
	```
- 3.配置pip环境变量
	如果自动配置成功，忽略这一步
	配置环境变量 C:/Python/Script

- 4.安装xlrd模块

	```
	$ pip install xlrd
	```


## excel表格格式
打开Hero.xlsx文件查看
- 1.第一行是中文配置，自己看的，随便写注释、
- 2.第二行是字段的key，程序中使用，必须按驼峰命名法（程序不用的字段，加”_”前缀，不会生成进lua文件里）
- 3.第三行是数据类型，int,float,string,bool,table;
- 4.下面都是具体的数据了，ID列必须填，且必须是数字，其他可以不填，不填有默认值，比如int：0，bool:false,string:'';
- 5策划填数值的时候，偶尔会遗漏数据，当存在空值时，依据字段类型，填上默认值。
- 6.支持一个字段填上多组数据，如”进阶消耗”字段，自定义类型”table”，代表{ {道具1id,道具1数量}，{道具2id,道具2数量}}, … }
