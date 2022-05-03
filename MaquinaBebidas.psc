Algoritmo MaquinaBebidas
	Definir opcion como entero;
	
	Opcion = 0;
	dinero = 0;
	vuelto = 0;
	
	Escribir 'ingrese la opcion de la bebida:';
	Escribir '1) Coca-Cola';
	Escribir '2) Fanta';
	Escribir '3) Sprite';
	Escribir '4) Fresca';
	Leer opcion;
	
	Si opcion >=1 & opcion <=3 Entonces
		Escribir 'Ingrese dinero';
		Leer dinero;
		Si dinero = 0.80 Entonces
			Escribir 'No tiene vuelto, disfrute su bebida';
		SiNo
			Si dinero >= 0.80 Entonces
				vuelto = dinero - 0.80;
				Escribir 'Su vuelto es; $', vuelto ', disfrute su bebida';
			SiNo
				Escribir 'Falta Dinero!!!';
			Fin Si
		Fin Si
		Si opcion = 1 Entonces
			Escribir 'Coca-Cola';
		FinSi
		Si opcion = 2 Entonces
			Escribir 'Fanta';
		Fin Si
		Si opcion = 3 Entonces
			Escribir'Sprite';
		FinSi
		Si opcion = 4 Entonces
			Escribir 'Fresca';
		FinSi
	SiNo
		Escribir 'La opcion ingresada no es valida';
	Fin Si
	
FinAlgoritmo
