using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bulky.Utility
{
    public class EmailSender : IEmailSender
    {
        //Microsoft.AspNetCore.Identity.UI install this package
        // yahan hm  ny isliye yeh cctreate ki q k refgister my email interface tha jo k implement nhi hota is liye
        // error a rha tha to abhi yeh usy fix krny k liye kia implememnt interface logic nhi likhi

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // logic to send the email

            return Task.CompletedTask;
        }
    }
}
    
