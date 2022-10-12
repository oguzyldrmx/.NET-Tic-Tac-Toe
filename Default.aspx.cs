using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    private static bool turn = true;
    private static int counter;

    protected bool change_bool(bool x)
    {
        if (x)
            ViewState["turn"] = false;
        else
            ViewState["turn"] = true;
        return x;
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = "0";
    }

    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        switch (Menu1.SelectedItem.Text)
        {
            case "New Game":
                
                break;
            case "Exit":
                System.Environment.Exit(1);
                break;
        }

    }
    int turn_count = 0;
    protected void button_Click(object sender, EventArgs e)
    {
        Button b = (Button)sender;
        if (turn)
            b.Text = "X";
        else
            b.Text = "O";

        counter++;
        turn = !turn;
        b.Enabled = false;
        TextBox1.Text = counter.ToString();

        checkWinner();
    }
    
    
}