// ************************************************************************
//  
// Copyright © 2010-2018 wuhan wangyou tec.Corporation,All Rights Reserved.
// 版权所有：     武汉网友科技有限公司
//
// 作者(Author):                    毛善丽
//
// 数据表(Table):
//
// 创建日期(Create Time):
//
// 说明（Description):
//
// 修改记录（Revision History)：
//    R1: 
//           
// ************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IterateCombine
{
    class CafeMenuIterator : Iterator
    {
        Hashtable table;
        int position = 0;
        public CafeMenuIterator(Hashtable table)
        {
            this.table = table;
        }
        public bool hasNext()
        {
            ICollection keys = table.Keys;
            if (position < keys.Count)
                return true;
            return false;
        }

        public object Next()
        {
            string[] lst = new string[table.Count];
            table.Keys.CopyTo(lst, 0);
            var  item =table[lst[position]];
            position++;
            return item;
        }
    }
}
