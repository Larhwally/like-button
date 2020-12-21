// JavaScript source code
function incrementValue() {
    var value = parseInt(document.getElementById('like-counter').value, 10);
    value = isNaN(value) ? 0 : value;
    value++;
    document.getElementById('like-counter').value = value;
    saveCountToDb(value);
}

async function getLikesCount() {
    let response = await fetch('https://localhost:44313/api/Likes');
    let data = await response.json();
    document.getElementById('like-counter').value = data;
}

async function saveCountToDb(value) {
    fetch('https://localhost:44313/api/Likes', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify({ likeCount: value }),
    })
        .then(response => response.json())
}
