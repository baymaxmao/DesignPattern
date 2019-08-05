using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DecorationPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender,EventArgs e)
        {
            this.richTextBox1.Text = "装饰者模式--\r\n 场景：星巴克订单-饮料+调料 " +
                "\r\n 思考：不使用观察者模式，所有调料抽象基类，提供cost方法，调料类实现该方法，饮料类中提供一个List添加调料类";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //如果配料价格改变了呢？调料需要多份
            InheritList.DarkRoast dr = new InheritList.DarkRoast(10);
            InheritList.Mocha mocha = new InheritList.Mocha(2);
            InheritList.Whip whip = new InheritList.Whip(3);
            dr.Add(mocha,1);
            dr.Add(whip,2);
            this.textBox2.Text = dr.Cost().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Beverage beverage = new Espresso();
           
            Beverage beverage2 = new HouseBlend();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2= new Whip(beverage2);
            this.richTextBox2.Text = beverage.getDescription() + "$" + beverage.cost() +
                "\n" + beverage2.getDescription() + "$" + beverage2.cost() ;
        }
    }
}
