using System;
using System.Collections.Generic;
using System.Text;

namespace ModelFunc
{
    /// <summary>
    /// 模板方法模式：在一个方法中定义一个算法的骨架，而将一些步骤延迟到子类中。模板方法
    /// 使得子类可以在不改变算法结构的情况下，重新定义算法中的某些步骤。
    /// </summary>
    public abstract class BaseAlgorithm
    {
        //算法抽象化-找共同点和不同点，共同点基类实现，不同点使用虚拟方法，子类实现
        //模板用来封装方法调用顺序，方法抽象出共同实现和独有实现
      
       
        /// <summary>
        /// TemplateMethod即模板方法，调用了父类的方法，和父类声明子类实现的方法
        /// 模板方法定义了一个算法的步骤，并允许子类为一个或多个步骤提供实现，这个模板控制了算法的流程，具体实现由子类决定
        /// 这种处理可以让算法的流程集中在父类中
        /// </summary>
         public void TemplateMethod()
         {
            boilWater();
            brew();
            pourInCup();
            
            //如果是这种用处，为什么不在子类的实现中将函数设置成空函数呢？钩子可以有更复杂的实现，用于算法分支判断
            //钩子有默认值，子类决定是否要实现它
            if(customerWantsCondiment())
                addCondiments();

        }
         void boilWater()
         {
            Console.WriteLine("boil water");
         }
         void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
         public abstract void brew();
         public abstract void addCondiments();
        //模板挂钩-钩子声明在抽象方法中，但只有空的或者默认的实现。
        //钩子可以让子类有能力对算法的不同点进行挂钩；要不要挂钩，由子类决定
        //
        //钩子示例-可以由子类决定是否实现
        public virtual bool customerWantsCondiment()
        {
            return true;
        }
    }
}
