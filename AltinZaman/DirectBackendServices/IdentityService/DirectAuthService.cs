using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TamTechSDK.Common.Providers.Requests.Models;
using TamTechSDK.Common.Services.Identity.Auth.Models;
using TamTechBackendSDK.IdentityService.Services.UserAccountServices.ResetPasswordService;
using TamTechBackendSDK.IdentityService.Services.UserAccountServices.ResetPasswordService.Models;
namespace TamTech.Web.DirectBackendServices.IdentityService
{
    public class DirectAuthService : BaseDirectService , TamTechSDK.Common.Services.Identity.IAuthService
    {

        private IResetPasswordByEmailSendingService _resetService;

        public DirectAuthService(IResetPasswordByEmailSendingService resetService)
        {
            _resetService = resetService;
        }
        
        public async Task<IRequestProviderResult<bool>> GenerateResetPasswordByEmailSendig(string email)
        {

            var result = await _resetService.GeneratePasswordResetTokenByEmailAsync(email);
            return ReturnResult(result.Data, result.Success);
        }

        public async Task<IRequestProviderResult<bool>> ResetPassword(ResetPassword password)
        {
            ResetPasswordByEmailModel data = new ResetPasswordByEmailModel
            {
                ConfirmPassword = password.ConfirmPassword,
                NewPassword = password.NewPassword,
                Token = password.Token,
                UserId = password.UserId
            };

            var result = await _resetService.ResetPassword(data);
            return ReturnResult(result.Data, result.Success);
 
        }
    }
}
