import { del, get, post, put } from "./api.js";

export async function getAllShoes() {
    return get('/data/shoes?sortBy=_createdOn%20desc');
}

export async function getShoesByBrand(query) {
return get(`/data/shoes?where=brand%20LIKE%20%22${query}%22`)
}

export async function getShoeById(id) {
    return get('/data/shoes/' + id)
}

export async function addShoe(shoe) {
    return post('/data/shoes/', shoe)
}

export async function updateShoe(id, shoe) {
    return put('/data/shoes/' + id, shoe);
}

export async function deleteShoe(id) {
    return del('/data/shoes/' + id);
}