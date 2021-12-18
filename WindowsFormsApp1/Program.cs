using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using static System.Data.CommandType;
using static WindowsFormsApp1.Repository;

namespace WindowsFormsApp1
{

    public class User
    {
        public User(int id, string login, string password)
        {
            Id = id;
            Login = login;
            Password = password;
        }

        public int Id { get; }
        public string Login { get; }
        public string Password { get; }

    }

    public class Feeder
    {
        public Feeder(int id, string name, int status)
        {
            Id = id;
            Name = name;
            Status = status;
        }

        public int Id { get; }
        public string Name { get; }
        public int Status { get; }

    }

    public class TypeFeeder
    {
        public TypeFeeder(int id, string type_feeder)
        {
            Id = id;
            typefeeder = type_feeder;
        }

        public int Id { get; }
        public string typefeeder { get; }

    }

    public class Schedule
    {
        public Schedule(int id, string name, int day, DateTime time)
        {
            Id = id;
            Name = name;
            Day = day;
            Time = time;
        }

        public int Id { get; }
        public string Name { get; }
        public int Day { get; }
        public DateTime Time { get; }

    }

    public class TypeFeed
    {
        public TypeFeed(int id, string type_feed)
        {
            Id = id;
            typefeed = type_feed;
        }

        public int Id { get; }
        public string typefeed { get; }

    }



    public static class ReaderExtensions
    {
        internal static int GetReturn(this SqlCommand command) =>
            (int)command.Parameters[ReturnValue].Value;
    }

    public static class Repository
    {
        private const int InvalidId = -1;
        private const string UserId = "id_users";
        private const string Login = "login";
        private const string Password = "password";
        private const string LoginVar = "@login";
        private const string PasswordVar = "@password";
        private const string AuthorizeProc = "SP_Authorize";
        public const string ReturnValue = "@return";

        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DataBaseCat;Integrated Security=True";
        private static readonly SqlConnection Connection = new SqlConnection(ConnectionString);


        private static SqlCommand Procedure(string name) =>
            new SqlCommand(name, Connection) { CommandType = StoredProcedure };

        private static SqlCommand ProcedureReturn(string name)
        {
            var cmd = Procedure(name);
            cmd.Parameters.Add(new SqlParameter(ReturnValue, SqlDbType.Int));
            cmd.Parameters[ReturnValue].Direction = ParameterDirection.ReturnValue;
            return cmd;
        }

        public static bool Authorize(string login, string password)
        {
            using (var command = Procedure(AuthorizeProc))
            {
                return command.GetReturn() != InvalidId;
            }
        }

    }

    internal class Program
    {

        [STAThread]
        private static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            string sqlExpression = "INSERT INTO User (login, password) VALUES ('admin', 'catfeeder')";
        }
    }
}