const uri = 'api/gardenitems';
let gardenItems = [];

function getItems() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => console.error('Unable to get items.', error));
}

function addItem() {
    const addNameTextbox = document.getElementById('add-name');
    const addHarvestTextbox = document.getElementById('add-harvest-notes');

    const item = {
        isSowed: false,
        name: addNameTextbox.value.trim(),
        harvestNotes: addHarvestTextbox.value.trim()
    };

    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(response => response.json())
        .then(() => {
            getItems();
            addNameTextbox.value = '';
            addHarvestTextbox.value = '';
        })
        .catch(error => console.error('Unable to add item.', error));
}

function deleteItem(id) {
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to delete item.', error));
}

function displayEditForm(id) {
    const item = gardenItems.find(item => item.id === id);
    //ce debug
    console.log('edit-item:');
    console.log(item);

    document.getElementById('edit-name').value = item.name;
    document.getElementById('edit-harvestNotes').value = item.harvestNotes;
    document.getElementById('edit-id').value = item.id;
    document.getElementById('edit-isSowed').checked = item.isSowed;
    document.getElementById('editForm').style.display = 'block';
}

function updateItem() {
    const itemId = document.getElementById('edit-id').value;
    const item = {
        id: parseInt(itemId, 10),
        isSowed: document.getElementById('edit-isSowed').checked,
        name: document.getElementById('edit-name').value.trim(),
        harvestNotes: document.getElementById('edit-harvestNotes').value.trim()
    };
    //ce debug
    console.log('updateItem - item');
    console.log(item);

    fetch(`${uri}/${itemId}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(item)
    })
        .then(() => getItems())
        .catch(error => console.error('Unable to update item.', error));

    closeInput();

    return false;
}

function closeInput() {
    document.getElementById('editForm').style.display = 'none';
}

function _displayCount(itemCount) {
    const name = (itemCount === 1) ? 'garden item' : 'garden items';

    document.getElementById('counter').innerText = `${itemCount} ${name}`;
}

function _displayItems(data) {
    const tBody = document.getElementById('gardenItems');
    tBody.innerHTML = '';

    _displayCount(data.length);
    //CE NOTES FOR DEBUGGING!
    console.log('data: ');
    console.log(data);

    const button = document.createElement('button');

    data.forEach(item => {
        let isSowedCheckbox = document.createElement('input');
        isSowedCheckbox.type = 'checkbox';
        isSowedCheckbox.disabled = true;
        //isCompleteCheckbox.checked = item.isComplete;
        isSowedCheckbox.checked = item.isSowed;

        let editButton = button.cloneNode(false);
        editButton.innerText = 'Edit';
        editButton.setAttribute('onclick', `displayEditForm(${item.id})`);

        let deleteButton = button.cloneNode(false);
        deleteButton.innerText = 'Delete';
        deleteButton.setAttribute('onclick', `deleteItem(${item.id})`);

        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        td1.appendChild(isSowedCheckbox);

        let td2 = tr.insertCell(1);
        let textNode = document.createTextNode(item.name);
        td2.appendChild(textNode);

        let td3 = tr.insertCell(2);
        let textNode1 = document.createTextNode(item.harvestNotes);
        td3.appendChild(textNode1);

        let td4 = tr.insertCell(3);
        td4.appendChild(editButton);

        let td5 = tr.insertCell(4);
        td5.appendChild(deleteButton);
    });

    gardenItems = data;
}