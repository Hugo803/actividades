Algoritmo máquina_refrescos
	Seguir<-"Si"
	
	Repetir
		
		Escribir "Bienvenidos al Mundo de los refrescos"
		
		Esperar 1 segundo
		
		Escribir "Tenemos gaseosas, jugos naturales, licuados"
		
		Esperar 1 segundo
		
		Escribir "Cual de ellas deseas beber ahora"  
		
		Esperar 1 segundo
		
		Escribir "Elige (1) para gaseosas, (2)  jugos naturales, (3)  licuados"
		
		Repetir
			
			Leer Opcion
			
			Si Opcion > 3 o Opcion < 1 Entonces
				
				Escribir "Error"
				
			Fin Si
			
		Hasta Que Opcion = 1 o Opcion = 2 o Opcion = 3 
		
		Si Opcion = 1 Entonces
			
			gaseosas<-"gaseosas"
			
		Fin Si
		
		Si Opcion = 2 Entonces
			
			jugos_naturales<-"jugos naturales"
			
		Fin Si
		
		Si Opcion = 3 Entonces
			
			licuados<-"licuados"
			
		Fin Si
		
		Escribir "Inserte Moneda"
		
		Repetir
			
			Leer Moneda
			
			Si Moneda <> 1 Entonces
				
				Escribir "Error"
				
			Fin Si
			
		Hasta Que Moneda = 1
		
		Escribir "Aqui esta su: ", +Gaseosas, " ,Que la disfrute, gracias"
		
		Escribir "Desea otro Refresco (s/n)"
		
		Repetir
			
			Leer Seguir
			
			Si Seguir <> "s" o Seguir <> "n" Entonces
	
			Fin Si
			
		Hasta Que Seguir = "s" o Seguir = "n"
		
	Hasta Que Seguir = "n"
	
FinAlgoritmo
