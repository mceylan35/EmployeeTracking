import { Injectable } from '@angular/core';
import { Customer } from 'src/app/entities/Customer';
import { HttpClientService } from '../http-client.service';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {
/*
  constructor(private httpClientService: HttpClientService, private toastrService: CustomToastrService) { }

  async create(customer: Customer): Promise<Create_User> {
    const observable: Observable<Create_User | Customer> = this.httpClientService.post<Create_User | Customer>({
      controller: "users"
    }, customer);

    return await firstValueFrom(observable) as Create_User;
  }

  async login(userNameOrEmail: string, password: string, callBackFunction?: () => void): Promise<any> {
    const observable: Observable<any | TokenResponse> = this.httpClientService.post<any | TokenResponse>({
      controller: "users",
      action: "login"
    }, { userNameOrEmail, password })

    const tokenResponse: TokenResponse = await firstValueFrom(observable) as TokenResponse;

    if (tokenResponse) {
      localStorage.setItem("accessToken", tokenResponse.token.accessToken);

      this.toastrService.message("Kullanıcı girişi başarıyla sağlanmıştır.", "Giriş Başarılı", {
        messageType: ToastrMessageType.Success,
        position: ToastrPosition.TopRight
      })
    }

    callBackFunction();
  }*/
}