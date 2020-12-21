// JavaScript source code

const baseURL = 'https://localhost:44313'

async function incrementValue() {
    let value = parseInt(document.getElementById('like-counter').value, 10);
    value = isNaN(value) ? 0 : value;
    value++;
    document.getElementById('like-counter').value = value;

    try {
        await saveCountToDb(value);
    } catch (error) {
        console.error(error);
        alert('An error occured while updating likes');
    }
}

async function getLikesCount() {
    try {
        const response = await fetch(`${baseURL}/api/Likes`);
        const data = await response.json();
        document.getElementById('like-counter').value = data;
    } catch (error) {
        console.error(error);
        alert('Could not load the number of likes');
    }
}

async function saveCountToDb(value) {
    const response = await fetch(`${baseURL}/api/Likes`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify({ likeCount: value }),
    });
    return await response.json();
}
