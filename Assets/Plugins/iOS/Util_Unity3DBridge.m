//
//  Util_Unity3DBridge.m
//
//  Created by Passion on 2019/10/14.
//  Copyright © 2019年 jiuwei. All rights reserved.
//


#if defined (__cplusplus)
extern "C" {
#endif

    void * getIPv6()
    {
        NSString *version = @"ipv6";
        return (void *)version.UTF8String;
    }
    
    
#if defined (__cplusplus)
}
#endif

