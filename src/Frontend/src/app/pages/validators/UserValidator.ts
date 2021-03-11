import { AbstractControl } from '@angular/forms'

export class UserValidator {
    static CPFValidation(control: AbstractControl): any {
        let cpf = control.value

        if (cpf != null && cpf.length === 11) {
            return null
        }
        else {
            return { cpfInvalidLength: true }
        }
    }
}
