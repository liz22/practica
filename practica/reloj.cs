/*
 * Created by SharpDevelop.
 * User: lizbeth
 * Date: 17/09/2013
 * Time: 10:36 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Reloj
{
	public class reloj
	{
		public reloj ()
		{
			
		}
		
		public void HoraActual(){
		DateTime HoraActual = DateTime.Now;
			for(;;){
        Console.WriteLine(DateTime.Now);
				System.Threading.Thread.Sleep(1000);
				Console.Clear ();
		 }
 	    }  
	}
}

