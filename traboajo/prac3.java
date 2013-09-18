import java.util.*;

public class prac3 {

	/**
	 * @param args                      
	 */
	public static void main(String[] args) {
		//Arreglo de 30 posiciones                                                                                               
		int[] a = new int[30];
		
		Random r = new Random();
		
		int aux;
		for (int i=0; i<30; i++){
			aux = r.nextInt(30);
			while( aux < 15)
				aux = r.nextInt(30);
			a[i] = aux;
			System.out.println("[" + a[i] +"]");
		}
		
		//Capturaar el valor de un articulo
		
		System.out.println("\nPROGRAMA PARA CALCULAR IVA");
		
		float pre, iva, total;
		Scanner sc=new Scanner(System. in);
		
		System.out.println("Ingrese el precio: "); 
		pre = sc.nextFloat();
		//System.out.println("El precio capturado fue: " + pre);
		iva = pre * 0.16f;
		System.out.println("El IVA es: " + iva);
		total = pre + iva;
		System.out.println("El precio total es: " + total);
		
		
		
		
		
	}
	
}