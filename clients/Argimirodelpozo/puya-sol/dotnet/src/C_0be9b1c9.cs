using System;
using Algorand;
using Algorand.Algod;
using Algorand.Algod.Model;
using Algorand.Algod.Model.Transactions;
using AVM.ClientGenerator;
using AVM.ClientGenerator.Core;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AVM.ClientGenerator.ABI.ARC56;
using Algorand.AVM.ClientGenerator.ABI.ARC56;

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_0be9b1c9
{


    public class CProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task PostInit(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> PostInit_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 204, 73, 227 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<bool> Test(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 158, 60, 196 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.Bool();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToBoolean(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Test_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 245, 158, 60, 196 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Constructor Bare Action
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            var result = await base.CallApp(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.CreateApplication)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 0, 193, 250, 21 };

            return await base.MakeTransactionList(new List<object> { }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJfX3Bvc3RJbml0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MSwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE2NF0sImVycm9yTWVzc2FnZSI6Il9fcG9zdEluaXQgYWxyZWFkeSBjYWxsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjddLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12WkdWd2JHOTVaV1JEYjJSbFJYaGpiSFZ6YVc5dUwzTjBZWFJwWTE5aVlYTmxYMloxYm1OMGFXOXVMbk52YkM1RExtRndjSEp2ZG1Gc1gzQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlnSW1SaGRHRWlDaUFnSUNCd2RYTm9hVzUwSURRd09UWUtJQ0FnSUdKNlpYSnZDaUFnSUNCa2RYQUtJQ0FnSUhOMGIzSmxJRFVLSUNBZ0lITjBiM0psSURBS0lDQWdJR3h2WVdRZ01Bb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBNE1Bb2dJQ0FnY21Wd2JHRmpaVElnTmpRS0lDQWdJSE4wYjNKbElEQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmlibm9nYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJS0lDQWdJR0o1ZEdWalh6QWdMeThnSWw5ZlkzUnZjbDl3Wlc1a2FXNW5JZ29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZmNIVjBDaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWpvS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdKaFkyTTBPV1V6SURCNFpqVTVaVE5qWXpRZ0x5OGdiV1YwYUc5a0lDSmZYM0J2YzNSSmJtbDBLQ2wyYjJsa0lpd2diV1YwYUc5a0lDSjBaWE4wS0NsaWIyOXNJZ29nSUNBZ2RIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNQW9nSUNBZ2JXRjBZMmdnYldGcGJsOWZYM0J2YzNSSmJtbDBYM0p2ZFhSbFFEVWdiV0ZwYmw5MFpYTjBYM0p2ZFhSbFFEWUtJQ0FnSUdWeWNnb0tiV0ZwYmw5MFpYTjBYM0p2ZFhSbFFEWTZDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREV5Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREV6T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCc2IyRmtJREFLSUNBZ0lITjBiM0psSURBS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1SaGRHRWlDaUFnSUNCaWIzaGZiR1Z1Q2lBZ0lDQndiM0FLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRE15Q2lBZ0lDQmlQZ29nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVEk2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVE1LQ20xaGFXNWZYMTl3YjNOMFNXNXBkRjl5YjNWMFpVQTFPZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlYMTlqZEc5eVgzQmxibVJwYm1jaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUY5ZmNHOXpkRWx1YVhRZ1lXeHlaV0ZrZVNCallXeHNaV1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbDlmWTNSdmNsOXdaVzVrYVc1bklnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKa1lYUmhJZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0prWVhSaElnb2dJQ0FnY0hWemFHSjVkR1Z6SUNKNFlYTnZjR05oTG5CdVoyRnBZbTVuYVdSaGF5NXFZblJ1ZFdSaGF5NWpRVkF1UWxKU1UwMURVRXBCUjFCRUlFdEpRVXBFVDAxSVZVdFNMRk5EVUVsRWVHRnpiM0JqWVM1d2JtZGhhV0p1WjJsa1lXc3VhbUowYm5Wa1lXc3VZMEZRTGtKU1VsTk5RMUJLUVVkUVJDQkxTVUZLUkU5TlNGVkxVaXhUUTFCSlJFMHNVMFZaUWtSWVEwNVVTMGxOVGtwSFR6dEVWVWxCVVVKUlZVVklRVXROVUVkSlJGTkJTa05QVlV0QlRrcENRMVZGUWt0T1FTNUhTVUZMVFZZdVZFbEJTazFQUEV0WVFrRk9Ta05RUjFWRUlFRkNTME5LU1VSSVFTQk9TMGxOUVVwVkxFVkxRVTFJVTA4N1VGbERRVXRWVFN4TUxsVkRRU0JOVWp0TFNWUkJUU3hUUlZsQ1JGaERUbFJMU1UxT1NrZFBPMFJWU1VGUlFsRlZSVWhCUzAxUVIwbEVVMEZLUTA5VlMwRk9Ta0pEVlVWQ1MwNUJMa2RKUVV0TlZpNVVTVUZLVFU4OFMxaENRVTVLUTFCSFZVUWdRVUpMUTBwSlJFaEJJRTVMU1UxQlNsVXNSVXRCVFVoVFR6dFFXVU5CUzFWTkxFd3VWVU5CSUUxU08wdEpWRUVnTGxKUVQwdEpSRUZUTEM1RFMxVk5WQzRzVDFKTFFVUWdMRTVQUzBsRVNFRWdMa05IUzBsQlJDQlBWa2hCVFZNZ1ExVkJUMGRVSUVSQlMwNGdUMGxVZUdGemIzQmpZUzV3Ym1kaGFXSnVaMmxrWVdzdWFtSjBiblZrWVdzdVkwRlFMa0pTVWxOTlExQktRVWRRUkNCTFNVRktSRTlOU0ZWTFVpeFRRMUJKUkUwc1UwVlpRa1JZUTA1VVMwbE5Ua3BIVHp0RVZVbEJVVUpSVlVWSVFVdE5VRWRKUkZOQlNrTlBWVXRCVGtwQ1ExVkZRa3RPUVM1SFNVRkxUVll1VkVsQlNrMVBQRXRZUWtGT1NrTlFSMVZFSUVGQ1MwTktTVVJJUVNCT1MwbE5RVXBWTEVWTFFVMUlVMDg3VUZsRFFVdFZUU3hNTGxWRFFTQk5VanRMU1ZSQllYQnBZbUZyY25CcFpHSmhZMjVwWkd0aFkycGhaSFJ1Y0dScmVXeGpZUzRzYW1SaExISXVhM1ZoWkdNc2FtUnNhMnBrSnl4akoyUnFMQ0J1WTJjZ1pHRnViM04xYldGdWRHdDFaR3RqTEdScWJuUjFaR3RoYm5SMVlXUnVZeXgxYVN4akxuVmtMQzV1ZFdwa2JtTjFaQ3hxTG5KelkyZ25jR3RzTGlkd2FXZ2lDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12WkdWd2JHOTVaV1JEYjJSbFJYaGpiSFZ6YVc5dUwzTjBZWFJwWTE5aVlYTmxYMloxYm1OMGFXOXVMbk52YkM1RExtTnNaV0Z5WDNOMFlYUmxYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUFnNWZYMk4wYjNKZmNHVnVaR2x1WndSa1lYUmhnWUFncjBrMUJUVUFOQUNBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0FYRUExQURFWVFBQUZLQ0puSWtNeEdSUkVNUmhFZ2dJRXVzeEo0d1Qxbmp6RU5ob0FqZ0lBTUFBQkFERVdRUUFtTVJZaUNUZ0lGRVEwQURVQUtiMUlGb0FCTXFXQUFRQWpUd0pVZ0FRVkgzeDFURkN3SWtNalF2L2NLR1JFS0NObktieElLWUNBQm5oaGMyOXdZMkV1Y0c1bllXbGlibWRwWkdGckxtcGlkRzUxWkdGckxtTkJVQzVDVWxKVFRVTlFTa0ZIVUVRZ1MwbEJTa1JQVFVoVlMxSXNVME5RU1VSNFlYTnZjR05oTG5CdVoyRnBZbTVuYVdSaGF5NXFZblJ1ZFdSaGF5NWpRVkF1UWxKU1UwMURVRXBCUjFCRUlFdEpRVXBFVDAxSVZVdFNMRk5EVUVsRVRTeFRSVmxDUkZoRFRsUkxTVTFPU2tkUE8wUlZTVUZSUWxGVlJVaEJTMDFRUjBsRVUwRktRMDlWUzBGT1NrSkRWVVZDUzA1QkxrZEpRVXROVmk1VVNVRktUVTg4UzFoQ1FVNUtRMUJIVlVRZ1FVSkxRMHBKUkVoQklFNUxTVTFCU2xVc1JVdEJUVWhUVHp0UVdVTkJTMVZOTEV3dVZVTkJJRTFTTzB0SlZFRk5MRk5GV1VKRVdFTk9WRXRKVFU1S1IwODdSRlZKUVZGQ1VWVkZTRUZMVFZCSFNVUlRRVXBEVDFWTFFVNUtRa05WUlVKTFRrRXVSMGxCUzAxV0xsUkpRVXBOVHp4TFdFSkJUa3BEVUVkVlJDQkJRa3REU2tsRVNFRWdUa3RKVFVGS1ZTeEZTMEZOU0ZOUE8xQlpRMEZMVlUwc1RDNVZRMEVnVFZJN1MwbFVRU0F1VWxCUFMwbEVRVk1zTGtOTFZVMVVMaXhQVWt0QlJDQXNUazlMU1VSSVFTQXVRMGRMU1VGRUlFOVdTRUZOVXlCRFZVRlBSMVFnUkVGTFRpQlBTVlI0WVhOdmNHTmhMbkJ1WjJGcFltNW5hV1JoYXk1cVluUnVkV1JoYXk1alFWQXVRbEpTVTAxRFVFcEJSMUJFSUV0SlFVcEVUMDFJVlV0U0xGTkRVRWxFVFN4VFJWbENSRmhEVGxSTFNVMU9Ta2RQTzBSVlNVRlJRbEZWUlVoQlMwMVFSMGxFVTBGS1EwOVZTMEZPU2tKRFZVVkNTMDVCTGtkSlFVdE5WaTVVU1VGS1RVODhTMWhDUVU1S1ExQkhWVVFnUVVKTFEwcEpSRWhCSUU1TFNVMUJTbFVzUlV0QlRVaFRUenRRV1VOQlMxVk5MRXd1VlVOQklFMVNPMHRKVkVGaGNHbGlZV3R5Y0dsa1ltRmpibWxrYTJGamFtRmtkRzV3Wkd0NWJHTmhMaXhxWkdFc2NpNXJkV0ZrWXl4cVpHeHJhbVFuTEdNblpHb3NJRzVqWnlCa1lXNXZjM1Z0WVc1MGEzVmthMk1zWkdwdWRIVmthMkZ1ZEhWaFpHNWpMSFZwTEdNdWRXUXNMbTUxYW1SdVkzVmtMR291Y25OamFDZHdhMnd1SjNCcGFMOGlRdz09IiwiY2xlYXIiOiJDb0VCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6OCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
