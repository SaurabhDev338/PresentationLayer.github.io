using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using BussinessLayer;
using System.Data;
using System.Data.SqlClient;


namespace PresentationLayer
{
    public partial class Page1 : System.Web.UI.Page
    {
        Entityclass objel = new Entityclass();
        Bussinessclass objbl = new Bussinessclass();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            Bindgrid();
        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                objel.Name = txt_name.Text;
                objel.Address = txt_address.Text;
                objel.mobile = txt_mobile.Text;
                objel.Email = txt_email.Text;
                objel.collage_Name = txt_collage.Text;
                objel.Gender = RadioBtn_gender.SelectedItem.Text;
                objel.Branch = txt_Branch.Text;
                objel.Skills = txt_skills.Text;

                int i = objbl.InsertIntoRegisTB(objel);
                

                if (i > 0)
                {
                    string s = @"alert('Data Inserted Successfully...!')";
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", s, true);
                    clear();
                }
                
                Bindgrid();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Bindgrid()
        {
            DataTable dt = new DataTable();
            dt = objbl.SelectRegisDB();
            gdvregis.DataSource = dt;    //datasource is dt, dt is source and gdvregis is registration
            gdvregis.DataBind();
        }

        protected void gdvregis_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(e.CommandArgument);

                if (e.CommandName=="View")
                {
                    ViewState["ID"] = a;
                    objel.ID = a;
                    DataTable dt = new DataTable();
                    dt = objbl.selectID(objel);
                    txt_name.Text = dt.Rows[0]["Name"].ToString();
                    txt_address.Text = dt.Rows[0]["Address"].ToString();
                    txt_mobile.Text = dt.Rows[0]["Mobile"].ToString();
                    txt_email.Text = dt.Rows[0]["Email"].ToString();
                    txt_collage.Text = dt.Rows[0]["Collage Name"].ToString();
                    txt_Branch.Text = dt.Rows[0]["Branch"].ToString();
                    txt_skills.Text = dt.Rows[0]["Skills"].ToString();
                    

                }
                else if(e.CommandName=="Delete")
                {                
                    objel.ID = Convert.ToInt32(a);
                    int i = objbl.deleterow(objel);

                if (i > 0)
                {
                    string s = @"alert('Data deleted Successfully...!')";
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", s, true);

                }
                Bindgrid();

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void Btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                objel.ID = Convert.ToInt32(ViewState["ID"]);
                objel.Name = txt_name.Text;
                objel.Address = txt_address.Text;
                objel.mobile = txt_mobile.Text;
                objel.Email = txt_email.Text;
                objel.collage_Name = txt_collage.Text;
                objel.Gender = RadioBtn_gender.SelectedItem.Text;
                objel.Branch = txt_Branch.Text;
                objel.Skills = txt_skills.Text;

                int i = objbl.updatetable(objel);
                
                if (i > 0)
                {
                    string s = @"alert('Data Updated Successfully...!')";
                    ScriptManager.RegisterStartupScript(this, GetType(), "alert", s, true);
                    clear();
                }
                
                Bindgrid();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void gdvregis_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public  void clear()
        {
             txt_name.Text="";
             txt_address.Text="";
             txt_mobile.Text="";
             txt_email.Text="";
             txt_collage.Text="";
             RadioBtn_gender.SelectedItem.Text="";
             txt_Branch.Text="";
             txt_skills.Text="";


        }
    }
}