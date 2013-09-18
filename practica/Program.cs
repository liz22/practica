/*
 * Created by SharpDevelop.
 * User: lizbeth
 * Date: 17/09/2013
 * Time: 10:35 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Reloj
{ 
	class Principal 
	{
		
		
		public void muestraMenu(){
			Console.WriteLine("Elige una opción");
			Console.WriteLine("1.Reloj\n2.Cronometro\n3.salir");	
		}
		
		
		
		public static void Main (string[] args)
		{
		int opc;
			
		Principal programa = new Principal();
			
			programa.muestraMenu();
			opc= int.Parse( Console.ReadLine() );
			switch(opc){
				
			case 1: 	
			for(;;){
					reloj unReloj = new reloj(); 
				    unReloj.HoraActual();
					}
				break;        
				
			case 2:
					Cronometro unCronometro = new Cronometro();
				    unCronometro.iniciarCronometro();
				break;
				
			
			default: Console.WriteLine("Opcion no valida");
				break;
			}

		}
		
		
	}
}
