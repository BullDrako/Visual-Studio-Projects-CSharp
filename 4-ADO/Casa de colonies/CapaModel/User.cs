using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModel
{
    public class User
    {
        //Properties
        #region Properties
        private int id_user;
        private String nickname;
        private String password;
        private int id_profile;

        private String nombre;
        private String apellidos;
        private String email;
        private String dni;
        private String telefono;
        private String num_ss;
        private String titulacion;

        #endregion
        //Constructors
        #region Constructors

        public User(String nickname, String password)
        {
            this.nickname = nickname;
            this.password = password;
        }

        public User (String nombre, String apellidos, String dni, String email, String telefono, String num_ss, String titulacion)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.email = email;
            this.telefono = telefono;
            this.num_ss = num_ss;
            this.titulacion = titulacion;

        }

        public User(String nombre, String apellidos, String dni, String email, String telefono)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
            this.email = email;
            this.telefono = telefono;
           

        }

        #endregion
        //Accessors
        #region Accessors
        public int Id_user
        {
            get { return id_user; }
            set { id_user = value; }
        }
        public String Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public int Id_profile
        {
            get { return id_profile; }
            set { id_profile = value; }
        }

        //----------------------------
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public String Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String Num_ss
        {
            get { return num_ss; }
            set { num_ss = value; }
        }

        public String Titulacion
        {
            get { return titulacion; }
            set { titulacion = value; }
        }


        #endregion
    }
}
