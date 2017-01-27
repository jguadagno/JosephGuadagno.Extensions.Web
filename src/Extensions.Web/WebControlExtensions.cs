using System.Web.UI;
using System.Web.UI.WebControls;

namespace JosephGuadagno.Extensions.Web
{
    /// <summary>
    /// Extension methods for WebControls
    /// </summary>
    public static class WebControlExtensions
    {
        /// <summary>
        /// Finds a child control with the <see cref="id"/> specified
        /// </summary>
        /// <typeparam name="T">The type that the control should be cast to</typeparam>
        /// <param name="control">The parent control</param>
        /// <param name="id">The id of the control you are looking for.</param>
        /// <returns>A control of type &lt;<see cref="T"/>&gt; if found, otherwise null</returns>
        public static T FindControl<T>(this Control control, string id) where T : class
        {
            return control.FindControl(id) as T;
        }

        /// <summary>
        /// Sets the value of a <see cref="DropDownList"> to the <see cref="value"/> specified if found</see>
        /// </summary>
        /// <param name="dropDownList">The DropDownList</param>
        /// <param name="value">The value you would like to set.</param>
        public static void SetDropDownValue(this DropDownList dropDownList, int value)
        {
            var item = dropDownList.Items.FindByValue(value.ToString());
            if (item != null)
                dropDownList.SelectedIndex = dropDownList.Items.IndexOf(item);
        }
    }
}