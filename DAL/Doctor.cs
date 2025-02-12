﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class Doctor
    {
        private Connection connection = new Connection();

        SqlDataReader read;
        DataTable tableData;
        SqlCommand command = new SqlCommand();

        public DataTable GetDoctors()
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarDoctores";
            command.CommandType = CommandType.StoredProcedure;
            read = command.ExecuteReader();
            tableData.Load(read);
            connection.CloseConnection();
            return tableData;
        }
        public string GetDoctorById(int doctorId)
        {
            string response = "";
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarDoctoresPorDpi";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@iddoctor", doctorId);
            command.Parameters.Add("@correo", SqlDbType.NVarChar, 250);
            command.Parameters["@correo"].Direction = ParameterDirection.Output;
            command.ExecuteNonQuery();
            response = Convert.ToString(command.Parameters["@correo"].Value);
            command.Parameters.Clear();
            connection.CloseConnection();
            return response;
        }
        public DataTable GetDoctorByDpi(string dpi)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "MostrarDoctorPorDpi";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@dpi", dpi);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }
        public DataTable GetDoctorByName(string name)
        {
            tableData = new DataTable();
            command.Connection = connection.OpenConnection();
            command.CommandText = "BuscarDocPorNombre";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@nombre", name);
            read = command.ExecuteReader();
            tableData.Load(read);
            command.Parameters.Clear();
            connection.CloseConnection();
            return tableData;
        }

        public void InsertDoctor(
            int userId,
            string doctorDpi,
            string firstName,
            string secondName,
            string thirdName,
            string firstSurname,
            string secondSurname,
            string number,
            string email,
            string specialty
            )
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "InsertarDoctor";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idusuario", userId);
            command.Parameters.AddWithValue("@dpi_doctores", doctorDpi);
            command.Parameters.AddWithValue("@primer_nombre", firstName);
            command.Parameters.AddWithValue("@segundo_nombre", secondName);
            command.Parameters.AddWithValue("@tercer_nombre", thirdName);
            command.Parameters.AddWithValue("@primer_apellido", firstSurname);
            command.Parameters.AddWithValue("@segundo_apellido", secondSurname);
            command.Parameters.AddWithValue("@numero", number);
            command.Parameters.AddWithValue("@correo", email);
            command.Parameters.AddWithValue("@especialidad",specialty);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

        public void UpdateDoctor(
            int userId,
            string doctorDpi,
            string firstName,
            string secondName,
            string thirdName,
            string firstSurname,
            string secondSurname,
            string number,
            string email,
            bool status,
            string specialty,
            int id
            )
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = "EditarDoctor";
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idusuario", userId);
            command.Parameters.AddWithValue("@dpi_doctores", doctorDpi);
            command.Parameters.AddWithValue("@primer_nombre", firstName);
            command.Parameters.AddWithValue("@segundo_nombre", secondName);
            command.Parameters.AddWithValue("@tercer_nombre", thirdName);
            command.Parameters.AddWithValue("@primer_apellido", firstSurname);
            command.Parameters.AddWithValue("@segundo_apellido", secondSurname);
            command.Parameters.AddWithValue("@numero", number);
            command.Parameters.AddWithValue("@correo", email);
            command.Parameters.AddWithValue("@estado", status);
            command.Parameters.AddWithValue("@especialidad", specialty);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
    }
}
