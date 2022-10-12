using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
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
                turn = true;
                counter = 0;
                EnableForm(Page.Controls);
                NewGameForm(Page.Controls);
                break;
            case "Exit":
                System.Environment.Exit(1);
                break;
        }

    }
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
    private void checkWinner()
    {
        bool there_is_a_winner = false;

        //Horizontal check
        if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            there_is_a_winner = true;
        if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            there_is_a_winner = true;
        if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            there_is_a_winner = true;
        //Vertical check
        else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            there_is_a_winner = true;
        else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            there_is_a_winner = true;
        else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            there_is_a_winner = true;
        //diagonal check
        else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            there_is_a_winner = true;
        else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            there_is_a_winner = true;


        if (there_is_a_winner)
        {
            DisableForm(Page.Controls);
            String winner = "";
            if (turn)
                winner = "0";
            else
                winner = "X";
            TextBox2.Text = winner + " Win!!!";
        }//end if
        else
        {
            if (counter == 9)
                TextBox2.Text = "Draw!!!";
            
        }
    }
    private void DisableForm(ControlCollection ctrls)
    {
        foreach (Control ctrl in ctrls)
        {
            if (ctrl is TextBox)
                ((TextBox)ctrl).Enabled = false;
            if (ctrl is Button)
                ((Button)ctrl).Enabled = false;

            DisableForm(ctrl.Controls);
        }
    }
    private void EnableForm(ControlCollection ctrls)
    {
        foreach (Control ctrl in ctrls)
        {
            if (ctrl is TextBox)
                ((TextBox)ctrl).Enabled = true;
            if (ctrl is Button)
                ((Button)ctrl).Enabled = true;

            EnableForm(ctrl.Controls);
        }
    }
    private void NewGameForm(ControlCollection ctrls)
    {
        foreach (Control ctrl in ctrls)
        {
            if (ctrl is TextBox)
                ((TextBox)ctrl).Text = "";
            if (ctrl is Button)
                ((Button)ctrl).Text = null;

            NewGameForm(ctrl.Controls);
        }
    }

}