using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string car_make="";
    public static int car_year, car_speed;
    public static Car car;
    public class Car
    {
        int speed = 0, year;
        string make;
        public Car(string make, int year, int speed)
        {
            this.make = make;
            this.year = year;
            this.speed = speed;
        }

        public int acc(int s)
        {            
            s = s + 5;
            return s;
        }
        public int brake(int s)
        {           
            if (s <= 4)
            {
                return 0;
            }
            else
            {
                s = s - 5;
                return s;
            }
        }
    }



    protected void Page_Load(object sender, EventArgs e)
    {
          
    }

    protected void Button_done_Click(object sender, EventArgs e)
    {
        
        if ((TextBox_year.Text=="")||(TextBox_make.Text=="")||(TextBox_speed.Text==""))
        {
            Label_info.Text = "Please enter all values";
            Label_info.Visible = true;
        }
        else
        {
           
            car_make = TextBox_make.Text;
            car_year = Convert.ToInt32(TextBox_year.Text);
            car_speed = Convert.ToInt32(TextBox_speed.Text);
            car = new Car(car_make,car_year,car_speed);
            Label_info.Visible = false;
            Button_done.Visible = false;
            Panel1.Visible = true;
        }
    }

    protected void Button_acc_Click(object sender, EventArgs e)
    {
        car_speed=car.acc(car_speed);
        TextBox_speed.Text = car_speed.ToString();
    }

    protected void Button_brake_Click(object sender, EventArgs e)
    {
        car_speed=car.brake(car_speed);
        TextBox_speed.Text = car_speed.ToString();
    }

    protected void Button_restart_Click(object sender, EventArgs e)
    {
        car_make = "";
        car_speed = 0;
        car_year = 0;
        TextBox_make.Text = "";
        TextBox_year.Text = "";
        TextBox_speed.Text = "";
        Panel1.Visible = false;
        Button_done.Visible = true;

    }
}