import { AbstractControl } from '@angular/forms'

export class AddUserValidator {
    static CPFValidation(control: AbstractControl): any {
        const cpf = control.value

        if (cpf.length === 11) {
            return null
        }
        else {
            return { cpfInvalidLength: true }
        }
    }
}
