﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaAccesoDatos;

namespace CapaLogicaNegocio
{
    public class PacienteLN
    {
        #region "PATRON SINGLETON"
        private static PacienteLN objEmpleado = null;
        private PacienteLN() { }
        public static PacienteLN getInstance()
        {
            if (objEmpleado == null)
            {
                objEmpleado = new PacienteLN();
            }
            return objEmpleado;
        }
        #endregion

        public bool RegistrarPaciente(Paciente objPaciente)
        {
            try
            {
                return PacienteDAO.getInstance().RegistrarPaciente(objPaciente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Paciente> ListarPacientes()
        {
            try
            {
                return PacienteDAO.getInstance().ListarPacientes();

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public bool Actualizar(Paciente objPaciente)
        {
            try
            {
                return PacienteDAO.getInstance().Actualizar(objPaciente);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

