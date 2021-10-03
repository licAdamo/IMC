/* Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Servicos
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre del alumna: Ada Nazcais Martin Morales
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using IMCApp.Api.entities;

namespace IMCApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IMCController : ControllerBase
    {
         [HttpPost]
        public string post( IMC iMC)
        {    
            String msg="";
             double Resultado;

            Resultado = (iMC.Peso / Math.Pow((iMC.Altura/100), 2));

            if(Resultado < 18.5)
            {
                 msg= "Su peso es inferior a lo normal";
            }
            else
            {
                if(Resultado>= 18.5  && Resultado <=24.9)
                {
                     msg="Su peso es correcto";
                }
                else
                {
                    if(Resultado>=25.00 && Resultado <= 29.9)
                    {
                         msg="Su Peso esta un poco mas alto de lo normal";
                    }
                    else
                    {
                         msg="Tienes sobre peso";
                    }
                }
                
            }
          return"Tu imc: "+ Convert.ToString(Resultado)+"Tu peso es:"+ msg;
           
        
        }

    }
    
}