using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    DateTime today = DateTime.Today;
    DayOfWeek dayOfWeek = DayOfWeek.Saturday;
    DateTime day1;
    DateTime day2;
    DateTime day3;

    protected void Page_Load(object sender, EventArgs e)
    {
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        Calendar1.SelectedDayStyle.BackColor = Color.Plum;
        Calendar1.SelectedDayStyle.ForeColor = Color.Black;
 
        //get the days to add
        int daysToAdd = DaysUntilDayOfWeek();

        //get the next 3 Saturdays
        day1 = today.AddDays(daysToAdd);
        day2 = today.AddDays(daysToAdd + 7);
        day3 = today.AddDays(daysToAdd + 14);
    }


    //DETERMINE DIFFERENCE IN DAYS BETWEEN TODAY AND DAY OF WEEK (SATURDAY) + DAYS TO ADD TO GET NEXT SATURDAY
    protected int DaysUntilDayOfWeek ()
    {
        int daysToAdd;
        if (today.DayOfWeek == dayOfWeek)
        {
            daysToAdd = 7;
        }
        else 
        {
            int dayDifference = (dayOfWeek - today.DayOfWeek);
            if (dayDifference < 0) //today is later in the week than chosen day
            {
                daysToAdd = dayDifference + 7;
            }
            else //today is earlier than chosen day
            {
                daysToAdd = dayDifference;
            }
        }
        return daysToAdd;
    }


    //ENABLE AND DISABLE APPROPRIATE DATES
    protected void DayRender(object sender, DayRenderEventArgs e)
    {
        if (e.Day.Date == day1 || e.Day.Date == day2 || e.Day.Date == day3)
        {
            e.Day.IsSelectable = true;
        }
        else
        {
            e.Day.IsSelectable = false; 
            e.Cell.BackColor = Color.LightGray;
            e.Cell.ForeColor = Color.DarkGray;
        }
    }


    //DISPLAY DATE USER SELECTED
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        lblSelection.Text = "You selected " + Calendar1.SelectedDate.ToLongDateString();
    }
    

    //UPDATE VOTE COUNTER AND GO TO RESULTS
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        DateTime selectedDate = Calendar1.SelectedDate;
        int day1Count;
        int day2Count;
        int day3Count;

        dateValidator.Validate();

        if (dateValidator.IsValid)
        {
            if (selectedDate == day1)
            {
                Application.Lock();
                day1Count = Convert.ToInt32(Application["day1Count"]);
                day1Count++;
                Application["day1Count"] = day1Count;
                Application.UnLock();
            }
            else if (selectedDate == day2)
            {
                Application.Lock();
                day2Count = Convert.ToInt32(Application["day2Count"]);
                day2Count++;
                Application["day2Count"] = day2Count;
                Application.UnLock();
            }
            else if (selectedDate == day3)
            {
                Application.Lock();
                day3Count = Convert.ToInt32(Application["day3Count"]);
                day3Count++;
                Application["day3Count"] = day3Count;
                Application.UnLock();
            }

            Response.Redirect("~/results.aspx");
        }
    }


    //MAKE SURE USER HAS SELECTED A DATE
    protected void dateValidator_ServerValidate(object source, ServerValidateEventArgs args)
    {
        args.IsValid = Calendar1.SelectedDate != default(DateTime);
    }
}