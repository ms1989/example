using System.Net.Mail;

namespace Mailer
{
	public class Mailer
	{

		private SmtpClient client;
		private MailMessage mes;

		public Mailer()
		{
			this.mes = new MailMessage("From@gmail.com", "toooo@gmail.com");
			this.client = new SmtpClient();
			client.Port = 587;
			client.DeliveryMethod = SmtpDeliveryMethod.Network;
			client.UseDefaultCredentials = false;
			client.EnableSsl = true;

			client.Credentials = new System.Net.NetworkCredential("example@gmail.com", "password");
			client.Host = "smtp.gmail.com";
			mes.Subject = "Test Subjecthhh";



			mes.Body = "Test Body";





		}


		public void send()
		{
			client.Send(mes);

		}

	}
}