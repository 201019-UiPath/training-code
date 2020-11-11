function GetPokemon()
{
    let xhr = new XMLHttpRequest();
    let pokemon = {};
    let pokemonInput = document.querySelector('#pokemonInput').value;
    //the ready state of the xhttp object determines the state of the request:
    // 0 - uninitialized
    // 1 - loading (server connection established) the open method has been invoked
    // 2 - loaded (request received by server) send has been called
    // 3 - interactive (processing request) response body is being received
    // 4 - complete (response received) 
    //the status code checks if the operation was successful
    xhr.onreadystatechange = function(){
        if(this.readyState == 4 && this.status == 200)
        {
            //JSON.parse is a function that converts the response body to a JS object
            pokemon = JSON.parse(xhr.responseText);
            document.querySelector('.pokemonResult img').setAttribute('src', pokemon.sprites.front_default);
            document.querySelectorAll('.pokemonResult caption').forEach((element) => element.remove());
            let caption = document.createElement('caption');
            let pokeName = document.createTextNode(pokemon.forms[0].name);
            caption.appendChild(pokeName);
            document.querySelector('.pokemonResult').appendChild(caption);
            document.querySelector('#pokemonInput').value = '';
        }
    };
    //creates the request
    //first parameter is the http method, second is the url/endpoint, third sets whether the request is async
    // By making the request async, the end user will be able to interact with the page while waiting for server response
    // The A in AJAX
    xhr.open("GET", `https://pokeapi.co/api/v2/pokemon/${pokemonInput}`, true);
    //Sends the request, has an optional parameter of request body data
    xhr.send();
}