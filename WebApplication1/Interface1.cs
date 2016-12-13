using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1
{
    public interface Interface1
    {
        int ab { get; set; }
        string actionone();
        void actiontwo();

    }
    public abstract class Abstract1 {
        public abstract string ab { get; set; }
        public abstract void actionthree();
        public abstract void actionthree1();

    }
    public class Virtual11
    {
        public virtual int uu { get; set; }
        public virtual void actionfour()
        {

        }
        public virtual void actionfour1()
        {

        }
    }
    public class b : Abstract1
    {
        public override string ab
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void actionthre()
        {

        }

        public override void actionthree()
        {
            //throw new NotImplementedException();
        }

        public override void actionthree1()
        {
            throw new NotImplementedException();
        }
    }
    public class a : Interface1
    {


        int Interface1.ab
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void c()
        {

        }
        public string actionone()
        {
            throw new NotImplementedException();
        }

        public void actiontwo()
        {
            throw new NotImplementedException();
        }
    }
    public class c : Virtual11
    {
        public override int uu { get; set; }
        public void aaa()
        {

        }
        public override void actionfour()
        {

        }
        public new void actionfour1()
        {

        }
    }
    public class dd {
        public void aa()
        {

        }
        public string aa(string a)
        {
            return "";
        }
    }
}
