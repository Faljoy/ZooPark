using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Visitor
    {
        public int AgeOfVisitor;
        public double MoneyOfVisitor;

        public Visitor(int AgeOfVisitor)
        {
            this.AgeOfVisitor = AgeOfVisitor;
            MoneyOfVisitor = new Random().Next(0,20000);
        }
    }
}
