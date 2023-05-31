export interface Kategoria {
    id?: number,
    kategoriaNev: string
}

export interface Teszt {
    id?: number,
    kerdes: string,
    v1: string,
    v2: string,
    v3: string,
    v4: string,
    helyes: string,
    kategoriaId: number
}