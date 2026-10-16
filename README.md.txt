# Práctica 3

### Situación 1

La gravedad solo afecta al cubo, que se queda en el plano. La esfera no tiene Rigidbody, así que se queda flotando.

![Situación 1](./GIFs/1.gif)

### Situación 2

La gravedad afecta al cubo y a la esfera. La esfera cae hasta el plano sin tocar el cubo.

![Situación 2](./GIFs/2.gif)

### Situación 3

La esfera es cinemática, así que la gravedad no le afecta y se queda flotando, igual que en la 1.

![Situación 3](./GIFs/3.gif)

### Situación 4

La gravedad afecta a los tres, incluido el plano. Sale un error en la consola y todo cae junto al vacío.

![Situación 4](./GIFs/4.gif)

### Situación 5

El plano es cinemático, así que la gravedad no le afecta y hace de suelo. La esfera pesa 10 veces más, pero cae igual de rápido.

![Situación 5](./GIFs/5.gif)

### Situación 6

Igual que la 5. La esfera pesa 100 veces más, pero la gravedad la hace caer igual de rápido.

![Situación 6](./GIFs/6.gif)

### Situación 7

Igual que la 4: la gravedad tira de todo hacia abajo, también del plano, así que no se ve la fricción.

![Situación 7](./GIFs/7.gif)

### Situación 8

La esfera es cinemática, así que la gravedad no le afecta. Flota y, como es Trigger, no bloquea nada.

![Situación 8](./GIFs/8.gif)

### Situación 9

La gravedad hace caer la esfera, pero como es Trigger atraviesa el plano y sigue cayendo sin parar.

![Situación 9](./GIFs/9.gif)

## Ejercicios

### Ejercicio 1

El personaje lleva un Rigidbody cinemático y se mueve con las flechas mediante `MovePosition` en `FixedUpdate`. Al ser cinemático, la gravedad no le afecta y el movimiento se controla por completo.

![Ejercicio 1](./GIFs/e1.gif)

### Ejercicio 2

Los objetos tienen Rigidbody dinámico y están a distintas alturas para que choquen al caer. Con `OnCollisionEnter` se muestra por consola el nombre del objeto con el que colisionan y se cambia el color.

![Ejercicio 2](./GIFs/e2.gif)

### Ejercicio 3

Las dos zonas son triggers. En la primera, el color cambia al entrar y vuelve al original al salir. En la segunda, al entrar se suma una sola vez un valor fijo a la variable de daño.

![Ejercicio 3](./GIFs/e3.gif)

### Ejercicio 4

Cada tipo de objeto está en su capa. En la matriz, los enemigos solo chocan con el jugador y con el suelo, para que no caigan. Los recolectables son triggers y solo se detectan por consola.

![Ejercicio 4](./GIFs/e4.gif)

### Ejercicio 5

Hay tres Physics Materials: resbaladizo, rugoso y de rebote. Al pulsar X, los objetos se lanzan con `AddForce` y cada uno reacciona de forma distinta según su material.

![Ejercicio 5](./GIFs/e5.gif)

### Ejercicio 6

Como el enunciado pide que ningún objeto tenga Rigidbody, el trigger del cubo no salta. La esfera va hacia el cilindro y atraviesa el cubo sin que este cambie de material.

![Ejercicio 6](./GIFs/e6.gif)