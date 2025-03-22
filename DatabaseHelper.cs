using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    // User 생활기록부
    // 회원 정보를 C#에서 저장하고 싶은거에요
    public class User
    {
        public int uno;
        public string id;
        public string pw;
        public string name;
        public DateTime birth;
        public string phone;
        public string email;
    }

    public class Location
    {
        public int lno;
        public string lname;
        public int lx;
        public int ly;
    }

    public class Schedule
    {
        public int sno;
        public DateTime date;
        public int starting;
        public int destination;
        public TimeSpan time;
    }

    public class Reservation
    {
        public int rno;
        public int uno;
        public int sno;
        public int carno;
        public string seat;
    }

    /// <summary>
    /// 데이터베이스쪽 일을 도와주는 동료, 클래스
    /// </summary>
    internal static class DatabaseHelper
    {
        static string connectionString = "server=localhost; database=Datarail; Uid=sa; Pwd=Rlaqudeo35584!#";

        public static void 연결확인()
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // 연결해라
                }

                MessageBox.Show("연결 성공");
            } catch(System.Exception)
            {
                MessageBox.Show("연결 실패 ㅠㅠ");
            }
        }

        public static void 회원정보출력()
        {
            string sql = "SELECT * FROM [user]";

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // 택배기사(SqlCommand) 고용
                    using(SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        // 상하차(물건 실어나르는) 직원들을 고용
                        using(SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                // 지금 가리키고 있는 행(Row)의 필드(Field)들을 출력해달라.
                                Console.WriteLine($"{reader["id"]} / {reader["pw"]} / {reader["name"]}");
                            }
                        }
                    }
                }
            } catch(System.Exception)
            {
                MessageBox.Show("회원정보출력 실패 ㅠㅠ");
            }
        }

        public static void 특정회원정보출력()
        {
            string sql = "SELECT * FROM [user] WHERE id='user01' AND pw='user01!'";

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using(SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        using(SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                Console.WriteLine($"{reader["id"]} / {reader["pw"]} / {reader["name"]}");
                            }
                        }
                    }
                }
            } catch(System.Exception)
            {
                MessageBox.Show("특정회원정보출력 실패 ㅠㅠ");
            }
        }

        public static bool 로그인성공확인(string id, string pw)
        {
            string sql = $"SELECT * FROM [user] WHERE id='{id}' AND pw='{pw}'";

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using(SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        using(SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            // id랑 pw 가진 회원이 있냐 == 행이 1개라도 있냐
                            if(reader.HasRows)
                            {
                                return true;
                            }
                        }
                    }
                }
            } catch(System.Exception)
            {
                MessageBox.Show("특정회원정보출력 실패 ㅠㅠ");
            }

            // 오류가 발생하거나 그런 회원 없으면 여기로 온다
            return false;     
        }

        public static User GetUserByIdAndPw(string id, string pw)
        {
            string sql = $"SELECT * FROM [user] WHERE id='{id}' AND pw='{pw}'";

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using(SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        using(SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                User user = new User(); // 새로운 생활기록부를 만든다

                                // 생활기록부를 채운다
                                user.uno = reader.GetInt32(0);
                                user.id = reader.GetString(1);
                                user.pw = reader.GetString(2);
                                user.name = reader.GetString(3);
                                user.birth = reader.GetDateTime(4);
                                user.phone = reader.GetString(5);
                                user.email = reader.GetString(6);

                                return user;
                            }
                        }
                    }
                }
            } catch(System.Exception)
            {
                MessageBox.Show("특정회원정보출력 실패 ㅠㅠ");
            }

            return null;
        }
        public static User GetUserByEmailAndPw(string email, string pw)
        {
            string sql = $"SELECT * FROM [user] WHERE email='{email}' AND pw='{pw}'";

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using(SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        using(SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                User user = new User(); // 새로운 생활기록부를 만든다

                                // 생활기록부를 채운다
                                user.uno = reader.GetInt32(0);
                                user.id = reader.GetString(1);
                                user.pw = reader.GetString(2);
                                user.name = reader.GetString(3);
                                user.birth = reader.GetDateTime(4);
                                user.phone = reader.GetString(5);
                                user.email = reader.GetString(6);

                                return user;
                            }
                        }
                    }
                }
            } catch(System.Exception)
            {
                MessageBox.Show("실패");
            }

            return null;
        }
        public static User GetUserByPhoneAndPw(string phone, string pw)
        {
            string sql = $"SELECT * FROM [user] WHERE phone='{phone}' AND pw='{pw}'";

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using(SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        using(SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                User user = new User(); // 새로운 생활기록부를 만든다

                                // 생활기록부를 채운다
                                user.uno = reader.GetInt32(0);
                                user.id = reader.GetString(1);
                                user.pw = reader.GetString(2);
                                user.name = reader.GetString(3);
                                user.birth = reader.GetDateTime(4);
                                user.phone = reader.GetString(5);
                                user.email = reader.GetString(6);

                                return user;
                            }
                        }
                    }
                }
            } catch(System.Exception)
            {
                MessageBox.Show("실패");
            }

            return null;
        }
        public static List<Location> GetLocationList()
        {
            List<Location> locationList = new List<Location>();
            string sql = $"SELECT * FROM [location]";

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using(SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        using(SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                Location location = new Location();

                                location.lno = reader.GetInt32(0);
                                location.lname = reader.GetString(1);
                                location.lx = reader.GetInt32(2);
                                location.ly = reader.GetInt32(3);

                                locationList.Add(location);
                            }
                        }
                    }
                }
            } catch(System.Exception)
            {
                MessageBox.Show("실패");
            }

            return locationList;
        }

        public static List<Schedule> GetScheduleByDateAndLocation(DateTime date, int lnoStart, int lnoDestination)
        {
            List<Schedule> scheduleList = new List<Schedule>();

            // date.ToShortDateString() -> 2025-04-08
            // 한줄로 쭉 치다가 길어지면 자르길 원하는 지점을 클릭하고 그냥 엔터를 누르면 됩니다 (+로 연결)
            string sql = $"SELECT * " +
                $"FROM [schedule] " +
                $"WHERE date='{date.ToShortDateString()}' " +
                $"AND starting={lnoStart} " +
                $"AND destination={lnoDestination} " +
                $"AND time>='{DateTime.Now.TimeOfDay}'"; // 현재 시간 이후부터 나타내시오.

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using(SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        using(SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                Schedule schedule = new Schedule();

                                schedule.sno = reader.GetInt32(0);
                                schedule.date = reader.GetDateTime(1);
                                schedule.starting = reader.GetInt32(2);
                                schedule.destination = reader.GetInt32(3);
                                schedule.time = reader.GetTimeSpan(4);

                                scheduleList.Add(schedule);
                            }
                        }
                    }
                }
            } catch(System.Exception)
            {
                MessageBox.Show("실패");
            }

            return scheduleList;
        }

        public static Schedule GetScheduleByDateAndTime(DateTime date, int starting, int destination, TimeSpan startTime)
        {
            List<Schedule> scheduleList = new List<Schedule>();

            string sql = $"SELECT * " +
                $"FROM [schedule] " +
                $"WHERE date='{date.ToShortDateString()}' " +
                $"AND starting={starting} " +
                $"AND destination={destination} " +
                $"AND time='{startTime}'";

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using(SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        using(SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                Schedule schedule = new Schedule();

                                schedule.sno = reader.GetInt32(0);
                                schedule.date = reader.GetDateTime(1);
                                schedule.starting = reader.GetInt32(2);
                                schedule.destination = reader.GetInt32(3);
                                schedule.time = reader.GetTimeSpan(4);

                                scheduleList.Add(schedule);
                            }
                        }
                    }
                }
            } catch(System.Exception)
            {
                MessageBox.Show("실패");
            }

            // 어차피 무조건 1개만 있는 것이 보장되어 0번째 스케줄 반환
            return scheduleList[0];
        }

        public static List<Reservation> GetReservationByScheduleAndCarNumber(int sno, int carno)
        {
            List<Reservation> reservationList = new List<Reservation>();

            string sql = $"SELECT * " +
                $"FROM [reservation] " +
                $"WHERE sno={sno}" +
                $"AND carno={carno}";

            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using(SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        using(SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                Reservation reservation = new Reservation();
                                reservation.rno = reader.GetInt32(0);
                                reservation.uno = reader.GetInt32(1);
                                reservation.sno = reader.GetInt32(2);
                                reservation.carno = reader.GetInt32(3);
                                reservation.seat = reader.GetString(4);

                                reservationList.Add(reservation);
                            }
                        }
                    }
                }
            } catch(System.Exception)
            {
                MessageBox.Show("실패");
            }

            return reservationList;
        }
    }
}