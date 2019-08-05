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
    class CompositeIterator : IEnumerator
    {
        Stack stack = new Stack();
        public CompositeIterator(IEnumerator enumerator)
        {
            stack.Push(enumerator);
        }
        public object Current
        {
            get
            {
                IEnumerator enumerator = (IEnumerator)stack.Peek();
               
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                IEnumerator enumer = menuComponent.createIEnumerator();
                if(menuComponent.GetType()==typeof(MenuTree))
                    stack.Push(enumer);
                return menuComponent;
            }
        }

            


        public bool MoveNext()
        {
            if (stack.Count == 0)
                return false;
            IEnumerator enumerator = (IEnumerator)stack.Peek();
            if (!enumerator.MoveNext())
            {
                stack.Pop();
                //递归调用
                return MoveNext();
            }
            return true;    
            
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
