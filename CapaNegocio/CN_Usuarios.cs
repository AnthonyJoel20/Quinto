using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaNegocio;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Data;


namespace CapaNegocio
{
    public class CN_Usuarios : DataClasses1DataContext
    {
        public static DataClasses1DataContext dc = new DataClasses1DataContext();


        //crear metodo
        public static List<TBL_USUARIO> getAllUsers()
        {
            try
            {
                dc = new DataClasses1DataContext();
                var lista = dc.TBL_USUARIO.Where(data => data.usu_status == 'A');

                return lista.ToList();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar los usuarios " + ex.Message);
            }
        }

        public static TBL_USUARIO getUsersXId(int idUsuario)
        {
            try
            {
                var usuario = dc.TBL_USUARIO.FirstOrDefault(data => data.usu_status == 'A'
                                                            && data.usu_id.Equals(idUsuario));
                return usuario;
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar los usuarios" + ex.Message);
            }
        }
        public static TBL_USUARIO userPass(string pass)
        {
            try
            {
                var contr = dc.TBL_USUARIO.FirstOrDefault(data => data.usu_status == 'A'
                                                                && data.usu_password.Equals(pass));
                return contr;
            }
            catch (Exception ex)
            {
                throw new ArgumentException("No se encuentra la ocntra" + ex.Message);
            }
        }
        public static List<TBL_USUARIO> getUsersXApellidos(string apellidos)
        {
            try
            {
                dc = new DataClasses1DataContext();
                var usuarios = dc.TBL_USUARIO.Where(data => data.usu_status == 'A'
                                                            && data.usu_apellidos.StartsWith(apellidos)).
                                                            OrderBy(data => data.usu_id).
                                                            ThenBy(data => data.usu_correo);
                return usuarios.ToList();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar los usuarios" + ex.Message);
            }
        }

        public static TBL_USUARIO getUsersxLogin(string email, string password)
        {
            try
            {
                var usuario = dc.TBL_USUARIO.FirstOrDefault(data => data.usu_status == 'A'
                                                            && data.usu_correo.Equals(email)
                                                            && data.usu_password.Equals(password));
                return usuario;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(" Error al consultar los usuarios " + ex.Message);
            }
        }


        public static bool saveUser(TBL_USUARIO _infoUsuario)
        {
            try
            {
                dc = new DataClasses1DataContext();
                bool resul = false;
                _infoUsuario.usu_status = 'A';
                _infoUsuario.usu_add = DateTime.Now;
                dc.TBL_USUARIO.InsertOnSubmit(_infoUsuario);
                dc.SubmitChanges();
                resul = true;
                return resul;


            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar los usuarios" + ex.Message);
            }
        }

        public static bool updateUser1(TBL_USUARIO _infoUsuario)
        {
            try
            {

                bool resul = false;
                dc.SubmitChanges();
                resul = true;
                return resul;

            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar los usuarios" + ex.Message);
            }
        }

        public static bool updateUser2(TBL_USUARIO _infoUsuario)
        {
            try
            {

                bool resul = false;
                dc.ExecuteCommand("UPDATE [dbo].[TBL_USUARIO] " +
      "SET[usu_correo] = { 0} " +
      ",[usu_password] = {1} " +
      ",[usu_apellidos] = {2} " +
      ",[usu_nombres] = {3} " +
      ",[rol_id] = {4} " +
    "WHERE[usu_id] = {5} ", new object[]
    {
        _infoUsuario.usu_correo,
       _infoUsuario.usu_password,
       _infoUsuario.usu_apellidos,
       _infoUsuario.usu_nombres,
       _infoUsuario.rol_id,
       _infoUsuario.usu_id
    });
                // envia el comando dml al contexto
                dc.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, dc.TBL_USUARIO);
                //Actualizo el contexto de datos
                dc.SubmitChanges();
                resul = true;
                return resul;


            }
            catch (Exception ex)
            {

                throw new ArgumentException("Error al consultar los usuarios" + ex.Message);
            }
        }



    }
}



