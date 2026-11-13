// La función se marca como 'async' para poder usar 'await' dentro de ella.
async function obtenerDatosDePokemon() {
    // 1. URL base y el recurso específico (Pikachu)
    const url = 'https://pokeapi.co/api/v2/pokemon/pikachu';

    try {
        // 2. Realizar la petición con fetch()
        // fetch() devuelve una Promise que se resuelve en el objeto Response.
        const respuesta = await fetch(url);

        // 3. Manejo de Errores HTTP
        // Si el estado de la respuesta no es 200-299 (ej. 404 Not Found), lanzamos un error.
        if (!respuesta.ok) {
            throw new Error(`¡Error! Código de estado: ${respuesta.status}`);
        }

        // 4. Extraer el cuerpo de la respuesta como JSON
        // .json() también es asíncrono y devuelve una Promise.
        const datosPokemon = await respuesta.json();

        // 5. Procesar los datos obtenidos
        console.log(`--- Información de ${datosPokemon.name.toUpperCase()} ---`);
        console.log(`ID: ${datosPokemon.id}`);
        
        // Acceder a la primera habilidad del array 'abilities'
        if (datosPokemon.abilities && datosPokemon.abilities.length > 0) {
            const primeraHabilidad = datosPokemon.abilities[0].ability.name;
            console.log(`Primera Habilidad: ${primeraHabilidad}`);
        } else {
            console.log('No se encontraron habilidades.');
        }

    } catch (error) {
        // 6. Manejo de errores de red o errores lanzados en el paso 3
        console.error('Hubo un problema al intentar obtener los datos:', error.message);
    }
}

// Llamar a la función para ejecutar la lógica.
obtenerDatosDePokemon();