function GetAllHeroes()
{
    fetch('https://localhost:44356/SuperHero/get')
    .then(response => response.json)
    .then(result => {
        document.querySelectorAll('#heroes tbody tr').forEach(element => element.remove());
        let table = document.querySelector('#heroes tbody');
        for(let i = 0; i < result.length(); ++i)
        {
            let row = table.insertRow(table.rows.length);
            let rnCell = row.Insert(0);
            rnCell.innerHTML = result[i].realName;

            let aCell = row.Insert(1);
            aCell.innerHTML = result[i].alias;

            let hideCell = row.Insert(2);
            hideCell.innerHTML = result[i].hideOut;

        }
    });
}