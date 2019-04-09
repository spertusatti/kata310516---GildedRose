#Kata II: Gilded Rose Refactor Kata
<p style="text-align:center; float: right;" align="center">
  <img align="center" src="http://s7.postimg.org/w1aay2wez/the_gilded_rose_banner.jpg" style="text-align:center; float: right;"/>
</p>
Se trata de un ejercicio de refactorización en el que vamos a tener que leer el código que hizo otra persona, comprender el nuevo desarrollo a afrontar que nos requiere el enunciado, diseñar los cambios i los tests, e implementarlos (primero tests, segundo funcionalidad).
Podéis descargaros el proyecto y el código en que nos basaremos para esta kata desde el siguiente enlace a un repositorio de GitHub: https://github.com/NotMyself/GildedRose 

#####NOTA: No haremos subidas de ningún tipo en ese repositorio. Las haremos en nuestras ramas del repositorio que figura más abajo.

### Al lio
El escenario es el  siguiente:
Una pequeña posada con una ubicación privilegiada en una importante ciudad, vende rosas bañadas en oro. El producto en cuestión se degrada constantemente con el paso del tiempo y es por eso que la posada tiene una aplicación que actualiza el estado de la calidad de sus productos en stock.
Podemos hacer todos los cambios que queramos al método UpdateQuality y añadir el código necesario, pero no se nos permite modificar la clase Item ni sus propiedades.

Las normas que rigen la aplicación son:
-	Todos los ítems tienen una propiedad SellIn para indicar la cantidad de días que quedan para venderse.
-	Todos los ítems tienen una propiedad Quality para indicar su estado actual.
-	Al final de cada día, el sistema decrementa ambas propiedades para cada ítem.
-	Si la cantidad de días para vender un ítem expira, su calidad decrecerá 2 veces más rápido.
-	La calidad de un ítem nunca será negativa.
-	Los ítems “Aged Brie” (Brie añejo), en realidad aumenta su calidad a más días transcurren.
-	La calidad de un ítem no será nunca superior a 50
-	Los ítems “Sulfuras”, que són legendarios, tienen una calidad constante de 80 y nunca deben venderse ya que entonces pierden calidad.
-	Los ítems “Backstage passes”, al igual que el Brie Añejo, aumentan en calidad según se consume la propiedad SellIn: la calidad aumenta en 2 si quedan 10 días o menos, aumenta en 3 cuándo quedan 5 días o menos pero la calidad pasa inmediatamente a ser 0 una vez ya ha tenido lugar el concierto. 

Nuestra tarea como desarroladores és:
-	Implementar lo necesario para que el sistema contemple un nuevo item Conjured, cuya calidad se vea degrada 2 veces más rápido que la de los ítems normales.


###¿Cómo oriento el desarrollo?
Aplicando lo que queráis sobre buenas prácticas y patrones (SOLID, SRP, KISS, TDD, etc.)
Eso sí, deben hacerse los Tests Unitarios. 

###¿En qué idioma?
En este caso, nos ceñiremos a las tecnologías y lenguajes en los que el código está disponible

###Fecha
La tendríamos que tener lista para el último martex del mes, en este caso el 26/04/2016, así quedamos y vemos que ha hecho cada uno.

###¡Donde la cuelgo!
Lo publicamos en el github de Tokiota directamente que está en https://github.com/Tokiota/kata310516---GildedRose

###Quiero hablar con alguien de esto.
Usad el canal de Slack #comunity-bp al que os podéis suscribir y así tenemos todos un punto de encuentro.

###Source
https://github.com/NotMyself/GildedRose 


