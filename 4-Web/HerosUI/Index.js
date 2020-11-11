function GetAllHeroes()
{
    debugger;
    fetch('https://localhost:44356/SuperHero/get')
    .then(response => response.json())
    .then(result => {
        document.querySelectorAll('#heroes tbody tr').forEach(element => element.remove());
        let table = document.querySelector('#heroes tbody');
        for(let i = 0; i < result.length; ++i)
        {
            debugger;
            let row = table.insertRow(table.rows.length);
            let rnCell = row.insertCell(0);
            rnCell.innerHTML = result[i].realName;

            let aCell = row.insertCell(1);
            aCell.innerHTML = result[i].alias;

            let hideCell = row.insertCell(2);
            hideCell.innerHTML = result[i].hideOut;

        }
    });
}