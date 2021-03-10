export class AddUserRequestModel {
    constructor(cpf: string, name: string) {
        this.cpf = cpf
        this.name = name
    }

    cpf: string
    name: string
}
