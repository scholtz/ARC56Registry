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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_d818a352
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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJfX3Bvc3RJbml0IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRlc3QiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoiYm9vbCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6dHJ1ZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzIwNF0sImVycm9yTWVzc2FnZSI6Il9fcG9zdEluaXQgYWxyZWFkeSBjYWxsZWQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDFdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBmIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzE0NF0sImVycm9yTWVzc2FnZSI6ImludmFsaWQgZnVuY3Rpb24gcG9pbnRlciIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEyOV0sImVycm9yTWVzc2FnZSI6Im5vdCBwYXlhYmxlIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZaR1Z3Ykc5NVpXUkRiMlJsUlhoamJIVnphVzl1TDNOMFlYUnBZMTlpWVhObFgyWjFibU4wYVc5dVgyUmxjR3h2ZVdWa0xuTnZiQzVETG1Gd2NISnZkbUZzWDNCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNU0F3Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0pmWDJOMGIzSmZjR1Z1WkdsdVp5SWdJbVJoZEdFaUlDSm1JZ29nSUNBZ2NIVnphR2x1ZENBME1EazJDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCemRHOXlaU0ExQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JzYjJGa0lEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd09EQUtJQ0FnSUhKbGNHeGhZMlV5SURZMENpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKZlgyTjBiM0pmY0dWdVpHbHVaeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXhDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RS0lDQWdJSEIxYzJoaWVYUmxjM01nTUhoaVlXTmpORGxsTXlBd2VHWTFPV1V6WTJNMElDOHZJRzFsZEdodlpDQWlYMTl3YjNOMFNXNXBkQ2dwZG05cFpDSXNJRzFsZEdodlpDQWlkR1Z6ZENncFltOXZiQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZYMTl3YjNOMFNXNXBkRjl5YjNWMFpVQTFJRzFoYVc1ZmRHVnpkRjl5YjNWMFpVQTJDaUFnSUNCbGNuSUtDbTFoYVc1ZmRHVnpkRjl5YjNWMFpVQTJPZ29nSUNBZ2RIaHVJRWR5YjNWd1NXNWtaWGdLSUNBZ0lHSjZJRzFoYVc1ZmRHVnlibUZ5ZVY5bVlXeHpaVUF4TWdvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF4Q2lBZ0lDQXRDaUFnSUNCbmRIaHVjeUJCYlc5MWJuUUtDbTFoYVc1ZmRHVnlibUZ5ZVY5dFpYSm5aVUF4TXpvS0lDQWdJQ0VLSUNBZ0lHRnpjMlZ5ZENBdkx5QnViM1FnY0dGNVlXSnNaUW9nSUNBZ1lubDBaV05mTVNBdkx5QWlaR0YwWVNJS0lDQWdJR0p2ZUY5blpYUUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VBb2dJQ0FnWTI5MlpYSWdNZ29nSUNBZ2MyVnNaV04wQ2lBZ0lDQnJaV05qWVdzeU5UWUtJQ0FnSUdsdWRHTmZNU0F2THlBd0NpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKbUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCbUlHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2FXNTJZV3hwWkNCbWRXNWpkR2x2YmlCd2IybHVkR1Z5Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd5TnpWa1pEUXpPV1kxT0dNNU5qRXdNR1UwTkRBd016RXpOekppTnprMk16Z3dZemxtWVRFek5tRTJPREkzTnpRMU0yUXdOVE5rWW1JNU9HVmpaRFpsQ2lBZ0lDQTlQUW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNREFLSUNBZ0lHbHVkR05mTVNBdkx5QXdDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJSE5sZEdKcGRBb2dJQ0FnY0hWemFHSjVkR1Z6SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDNSbGNtNWhjbmxmWm1Gc2MyVkFNVEk2Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNQW9nSUNBZ1lpQnRZV2x1WDNSbGNtNWhjbmxmYldWeVoyVkFNVE1LQ20xaGFXNWZYMTl3YjNOMFNXNXBkRjl5YjNWMFpVQTFPZ29nSUNBZ1lubDBaV05mTUNBdkx5QWlYMTlqZEc5eVgzQmxibVJwYm1jaUNpQWdJQ0JoY0hCZloyeHZZbUZzWDJkbGRBb2dJQ0FnWVhOelpYSjBJQzh2SUY5ZmNHOXpkRWx1YVhRZ1lXeHlaV0ZrZVNCallXeHNaV1FLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbDlmWTNSdmNsOXdaVzVrYVc1bklnb2dJQ0FnYVc1MFkxOHhJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0JpZVhSbFkxOHhJQzh2SUNKa1lYUmhJZ29nSUNBZ1ltOTRYMlJsYkFvZ0lDQWdjRzl3Q2lBZ0lDQmllWFJsWTE4eElDOHZJQ0prWVhSaElnb2dJQ0FnY0hWemFHSjVkR1Z6SUNKNFlYTnZjR05oTG5CdVoyRnBZbTVuYVdSaGF5NXFZblJ1ZFdSaGF5NWpRVkF1UWxKU1UwMURVRXBCUjFCRUlFdEpRVXBFVDAxSVZVdFNMRk5EVUVsRWVHRnpiM0JqWVM1d2JtZGhhV0p1WjJsa1lXc3VhbUowYm5Wa1lXc3VZMEZRTGtKU1VsTk5RMUJLUVVkUVJDQkxTVUZLUkU5TlNGVkxVaXhUUTFCSlJFMHNVMFZaUWtSWVEwNVVTMGxOVGtwSFR6dEVWVWxCVVVKUlZVVklRVXROVUVkSlJGTkJTa05QVlV0QlRrcENRMVZGUWt0T1FTNUhTVUZMVFZZdVZFbEJTazFQUEV0WVFrRk9Ta05RUjFWRUlFRkNTME5LU1VSSVFTQk9TMGxOUVVwVkxFVkxRVTFJVTA4N1VGbERRVXRWVFN4TUxsVkRRU0JOVWp0TFNWUkJUU3hUUlZsQ1JGaERUbFJMU1UxT1NrZFBPMFJWU1VGUlFsRlZSVWhCUzAxUVIwbEVVMEZLUTA5VlMwRk9Ta0pEVlVWQ1MwNUJMa2RKUVV0TlZpNVVTVUZLVFU4OFMxaENRVTVLUTFCSFZVUWdRVUpMUTBwSlJFaEJJRTVMU1UxQlNsVXNSVXRCVFVoVFR6dFFXVU5CUzFWTkxFd3VWVU5CSUUxU08wdEpWRUVnTGxKUVQwdEpSRUZUTEM1RFMxVk5WQzRzVDFKTFFVUWdMRTVQUzBsRVNFRWdMa05IUzBsQlJDQlBWa2hCVFZNZ1ExVkJUMGRVSUVSQlMwNGdUMGxVZUdGemIzQmpZUzV3Ym1kaGFXSnVaMmxrWVdzdWFtSjBiblZrWVdzdVkwRlFMa0pTVWxOTlExQktRVWRRUkNCTFNVRktSRTlOU0ZWTFVpeFRRMUJKUkUwc1UwVlpRa1JZUTA1VVMwbE5Ua3BIVHp0RVZVbEJVVUpSVlVWSVFVdE5VRWRKUkZOQlNrTlBWVXRCVGtwQ1ExVkZRa3RPUVM1SFNVRkxUVll1VkVsQlNrMVBQRXRZUWtGT1NrTlFSMVZFSUVGQ1MwTktTVVJJUVNCT1MwbE5RVXBWTEVWTFFVMUlVMDg3VUZsRFFVdFZUU3hNTGxWRFFTQk5VanRMU1ZSQllYQnBZbUZyY25CcFpHSmhZMjVwWkd0aFkycGhaSFJ1Y0dScmVXeGpZUzRzYW1SaExISXVhM1ZoWkdNc2FtUnNhMnBrSnl4akoyUnFMQ0J1WTJjZ1pHRnViM04xYldGdWRHdDFaR3RqTEdScWJuUjFaR3RoYm5SMVlXUnVZeXgxYVN4akxuVmtMQzV1ZFdwa2JtTjFaQ3hxTG5KelkyZ25jR3RzTGlkd2FXZ2lDaUFnSUNCaWIzaGZjSFYwQ2lBZ0lDQmllWFJsWTE4eUlDOHZJQ0ptSWdvZ0lDQWdhVzUwWTE4d0lDOHZJREVLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12WkdWd2JHOTVaV1JEYjJSbFJYaGpiSFZ6YVc5dUwzTjBZWFJwWTE5aVlYTmxYMloxYm1OMGFXOXVYMlJsY0d4dmVXVmtMbk52YkM1RExtTnNaV0Z5WDNOMFlYUmxYM0J5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFS0lDQWdJSEpsZEhWeWJnbz0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBbUF3NWZYMk4wYjNKZmNHVnVaR2x1WndSa1lYUmhBV2FCZ0NDdlNUVUZOUUEwQUlBZ0FBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBSUJjUURVQU1SaEFBQVVvSW1jaVF6RVpGRVF4R0VTQ0FnUzZ6RW5qQlBXZVBNUTJHZ0NPQWdCV0FBRUFNUlpCQUV3eEZpSUpPQWdVUkNtK2dBQk9BazBDSXlwbFJDSVNSSUFnSjEzVU9mV01saEFPUkFBeE55dDVZNERKK2hOcWFDZDBVOUJUMjdtT3pXNFNnQUVBSTA4Q1ZJQUVGUjk4ZFV4UXNDSkRJMEwvdGloa1JDZ2paeW04U0NtQWdBWjRZWE52Y0dOaExuQnVaMkZwWW01bmFXUmhheTVxWW5SdWRXUmhheTVqUVZBdVFsSlNVMDFEVUVwQlIxQkVJRXRKUVVwRVQwMUlWVXRTTEZORFVFbEVlR0Z6YjNCallTNXdibWRoYVdKdVoybGtZV3N1YW1KMGJuVmtZV3N1WTBGUUxrSlNVbE5OUTFCS1FVZFFSQ0JMU1VGS1JFOU5TRlZMVWl4VFExQkpSRTBzVTBWWlFrUllRMDVVUzBsTlRrcEhUenRFVlVsQlVVSlJWVVZJUVV0TlVFZEpSRk5CU2tOUFZVdEJUa3BDUTFWRlFrdE9RUzVIU1VGTFRWWXVWRWxCU2sxUFBFdFlRa0ZPU2tOUVIxVkVJRUZDUzBOS1NVUklRU0JPUzBsTlFVcFZMRVZMUVUxSVUwODdVRmxEUVV0VlRTeE1MbFZEUVNCTlVqdExTVlJCVFN4VFJWbENSRmhEVGxSTFNVMU9Ta2RQTzBSVlNVRlJRbEZWUlVoQlMwMVFSMGxFVTBGS1EwOVZTMEZPU2tKRFZVVkNTMDVCTGtkSlFVdE5WaTVVU1VGS1RVODhTMWhDUVU1S1ExQkhWVVFnUVVKTFEwcEpSRWhCSUU1TFNVMUJTbFVzUlV0QlRVaFRUenRRV1VOQlMxVk5MRXd1VlVOQklFMVNPMHRKVkVFZ0xsSlFUMHRKUkVGVExDNURTMVZOVkM0c1QxSkxRVVFnTEU1UFMwbEVTRUVnTGtOSFMwbEJSQ0JQVmtoQlRWTWdRMVZCVDBkVUlFUkJTMDRnVDBsVWVHRnpiM0JqWVM1d2JtZGhhV0p1WjJsa1lXc3VhbUowYm5Wa1lXc3VZMEZRTGtKU1VsTk5RMUJLUVVkUVJDQkxTVUZLUkU5TlNGVkxVaXhUUTFCSlJFMHNVMFZaUWtSWVEwNVVTMGxOVGtwSFR6dEVWVWxCVVVKUlZVVklRVXROVUVkSlJGTkJTa05QVlV0QlRrcENRMVZGUWt0T1FTNUhTVUZMVFZZdVZFbEJTazFQUEV0WVFrRk9Ta05RUjFWRUlFRkNTME5LU1VSSVFTQk9TMGxOUVVwVkxFVkxRVTFJVTA4N1VGbERRVXRWVFN4TUxsVkRRU0JOVWp0TFNWUkJZWEJwWW1GcmNuQnBaR0poWTI1cFpHdGhZMnBoWkhSdWNHUnJlV3hqWVM0c2FtUmhMSEl1YTNWaFpHTXNhbVJzYTJwa0p5eGpKMlJxTENCdVkyY2daR0Z1YjNOMWJXRnVkR3QxWkd0akxHUnFiblIxWkd0aGJuUjFZV1J1WXl4MWFTeGpMblZrTEM1dWRXcGtibU4xWkN4cUxuSnpZMmduY0d0c0xpZHdhV2kvS2lKbklrTT0iLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
