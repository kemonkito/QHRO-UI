﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetPatientTableAdapters;
using System.Data;

namespace BLL
{
    public class ClassPatient
    {
        private pacientesTableAdapter PATIENT;

        public ClassPatient()
        {
            PATIENT = new pacientesTableAdapter();
        }

        public DataTable listPatients()
        {
            return PATIENT.GetDataPatient();
        }

        public string newPatient(string historyNumber, string firstName, string secondName,
        string thirdName, string firstSurname, string secondSurname, short age, string diagnosis,
        string gender, bool status)
        {
            try
            {
                PATIENT.InsertQueryNewPatient(historyNumber, firstName, secondName, thirdName,
                    firstSurname, secondSurname, age, diagnosis, gender, status);
                return "Nuevo paciente agregado";
            }
            catch (Exception error)
            {
                return "ERROR" + error.Message;
            }
        }

        public string editPatient(string historyNumber, string firstName, string secondName,
        string thirdName, string firstSurname, string secondSurname, short age, string diagnosis,
        string gender, bool status, int idPatient)
        {
            try
            {
                PATIENT.UpdateQueryEditPatient(historyNumber, firstName, secondName, thirdName,
                    firstSurname, secondSurname, age, diagnosis, gender, status, idPatient);
                return "Se actualizaron los datos del paciente";
            }
            catch (Exception error)
            {

                return "ERROR" + error.Message;
            }
        }

    }
}
