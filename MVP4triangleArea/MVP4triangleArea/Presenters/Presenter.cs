using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP4triangleArea.View;
using MVP4triangleArea.Model;

namespace MVP4triangleArea.Presenters
{
    public class Presenter
    {
        private readonly IView view;

        public Presenter(IView view)
        {
            this.view = view;
        }

        public void getArea()
        {
            Triangle triangle = new Triangle();
            triangle.Side1 = Double.Parse(view.Side1);
            triangle.Side2 = Double.Parse(view.Side2);
            triangle.Side3 = Double.Parse(view.Side3);
            view.Area = triangle.getArea().ToString();
        }
    }
}
