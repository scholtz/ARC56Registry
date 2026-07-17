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

namespace Arc56.Generated.bcloud7.algorand_fun.Algodice_0269a775
{


    public class AlgodiceProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public AlgodiceProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay"> </param>
        public async Task<string> RollAlwaysLose(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 3, 10, 254, 217 };

            var result = await base.CallApp(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RollAlwaysLose_Transactions(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 3, 10, 254, 217 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="pay"> </param>
        public async Task<string> RollAlwaysWin(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 214, 107, 145, 187 };

            var result = await base.CallApp(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> RollAlwaysWin_Transactions(PaymentTransaction pay, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            _tx_transactions.AddRange(new List<Transaction> { pay });
            byte[] abiHandle = { 214, 107, 145, 187 };

            return await base.MakeTransactionList(new List<object> { abiHandle, pay }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        public async Task<string> Hello(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> Hello_Transactions(string name, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 2, 190, 206, 17 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQWxnb2RpY2UiLCJkZXNjIjpudWxsLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoicm9sbF9hbHdheXNfbG9zZSIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJwYXkiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJwYXkiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJyb2xsX2Fsd2F5c193aW4iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoicGF5Iiwic3RydWN0IjpudWxsLCJuYW1lIjoicGF5IiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaGVsbG8iLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTc4LDIwOF0sImVycm9yTWVzc2FnZSI6Ik1pbmltdW0gYmV0IHNpemUgaXMgMC4xIEFMR08iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1NSw4NSwxMTldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNThdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls1OCw4OCwxMjJdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTcxLDIwMF0sImVycm9yTWVzc2FnZSI6InBheW1lbnQgc2VuZGVyIG11c3QgbWF0Y2ggdHJhbnNhY3Rpb24gc2VuZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbOTgsMTMyXSwiZXJyb3JNZXNzYWdlIjoidHJhbnNhY3Rpb24gdHlwZSBpcyBwYXkiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFd0NpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4SURFd01EQXdNQ0F4TURBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlpHbGpaUzlqYjI1MGNtRmpkQzV3ZVRveE9Rb2dJQ0FnTHk4Z1kyeGhjM01nUVd4bmIyUnBZMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQTRDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRNRE13WVdabFpEa2dNSGhrTmpaaU9URmlZaUF3ZURBeVltVmpaVEV4SUM4dklHMWxkR2h2WkNBaWNtOXNiRjloYkhkaGVYTmZiRzl6WlNod1lYa3BjM1J5YVc1bklpd2diV1YwYUc5a0lDSnliMnhzWDJGc2QyRjVjMTkzYVc0b2NHRjVLWE4wY21sdVp5SXNJRzFsZEdodlpDQWlhR1ZzYkc4b2MzUnlhVzVuS1hOMGNtbHVaeUlLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZjbTlzYkY5aGJIZGhlWE5mYkc5elpWOXliM1YwWlVBeklHMWhhVzVmY205c2JGOWhiSGRoZVhOZmQybHVYM0p2ZFhSbFFEUWdiV0ZwYmw5b1pXeHNiMTl5YjNWMFpVQTFDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRJNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIyUnBZMlV2WTI5dWRISmhZM1F1Y0hrNk1Ua0tJQ0FnSUM4dklHTnNZWE56SUVGc1oyOWthV05sS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCd2RYTm9hVzUwSURBZ0x5OGdNQW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYMmhsYkd4dlgzSnZkWFJsUURVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIyUnBZMlV2WTI5dWRISmhZM1F1Y0hrNk5ERUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklFOXVRMjl0Y0d4bGRHbHZiaUJwY3lCdWIzUWdUbTlQY0FvZ0lDQWdkSGh1SUVGd2NHeHBZMkYwYVc5dVNVUUtJQ0FnSUdGemMyVnlkQ0F2THlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z2JtOTBJR055WldGMGFXNW5DaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMlJwWTJVdlkyOXVkSEpoWTNRdWNIazZNVGtLSUNBZ0lDOHZJR05zWVhOeklFRnNaMjlrYVdObEtFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmxlSFJ5WVdOMElESWdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlrYVdObEwyTnZiblJ5WVdOMExuQjVPalF4Q2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrS0NrS0lDQWdJR05oYkd4emRXSWdhR1ZzYkc4S0lDQWdJR1IxY0FvZ0lDQWdiR1Z1Q2lBZ0lDQnBkRzlpQ2lBZ0lDQmxlSFJ5WVdOMElEWWdNZ29nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dwdFlXbHVYM0p2Ykd4ZllXeDNZWGx6WDNkcGJsOXliM1YwWlVBME9nb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWthV05sTDJOdmJuUnlZV04wTG5CNU9qTXdDaUFnSUNBdkx5QkFZWEpqTkM1aFltbHRaWFJvYjJRS0lDQWdJSFI0YmlCUGJrTnZiWEJzWlhScGIyNEtJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJQYmtOdmJYQnNaWFJwYjI0Z2FYTWdibTkwSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmhjM05sY25RZ0x5OGdZMkZ1SUc5dWJIa2dZMkZzYkNCM2FHVnVJRzV2ZENCamNtVmhkR2x1WndvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZzWjI5a2FXTmxMMk52Ym5SeVlXTjBMbkI1T2pFNUNpQWdJQ0F2THlCamJHRnpjeUJCYkdkdlpHbGpaU2hCVWtNMFEyOXVkSEpoWTNRcE9nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0F0Q2lBZ0lDQmtkWEFLSUNBZ0lHZDBlRzV6SUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdjR0Y1Q2lBZ0lDQTlQUW9nSUNBZ1lYTnpaWEowSUM4dklIUnlZVzV6WVdOMGFXOXVJSFI1Y0dVZ2FYTWdjR0Y1Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjJScFkyVXZZMjl1ZEhKaFkzUXVjSGs2TXpBS0lDQWdJQzh2SUVCaGNtTTBMbUZpYVcxbGRHaHZaQW9nSUNBZ1kyRnNiSE4xWWlCeWIyeHNYMkZzZDJGNWMxOTNhVzRLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekFnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ3B0WVdsdVgzSnZiR3hmWVd4M1lYbHpYMnh2YzJWZmNtOTFkR1ZBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlpHbGpaUzlqYjI1MGNtRmpkQzV3ZVRveU1Rb2dJQ0FnTHk4Z1FHRnlZelF1WVdKcGJXVjBhRzlrQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WkdsalpTOWpiMjUwY21GamRDNXdlVG94T1FvZ0lDQWdMeThnWTJ4aGMzTWdRV3huYjJScFkyVW9RVkpETkVOdmJuUnlZV04wS1RvS0lDQWdJSFI0YmlCSGNtOTFjRWx1WkdWNENpQWdJQ0JwYm5Salh6QWdMeThnTVFvZ0lDQWdMUW9nSUNBZ1pIVndDaUFnSUNCbmRIaHVjeUJVZVhCbFJXNTFiUW9nSUNBZ2FXNTBZMTh3SUM4dklIQmhlUW9nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCMGNtRnVjMkZqZEdsdmJpQjBlWEJsSUdseklIQmhlUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlrYVdObEwyTnZiblJ5WVdOMExuQjVPakl4Q2lBZ0lDQXZMeUJBWVhKak5DNWhZbWx0WlhSb2IyUUtJQ0FnSUdOaGJHeHpkV0lnY205c2JGOWhiSGRoZVhOZmJHOXpaUW9nSUNBZ1pIVndDaUFnSUNCc1pXNEtJQ0FnSUdsMGIySUtJQ0FnSUdWNGRISmhZM1FnTmlBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3hOVEZtTjJNM05Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyY0tJQ0FnSUdsdWRHTmZNQ0F2THlBeENpQWdJQ0J5WlhSMWNtNEtDbTFoYVc1ZlltRnlaVjl5YjNWMGFXNW5RRGc2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjJScFkyVXZZMjl1ZEhKaFkzUXVjSGs2TVRrS0lDQWdJQzh2SUdOc1lYTnpJRUZzWjI5a2FXTmxLRUZTUXpSRGIyNTBjbUZqZENrNkNpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRREV5Q2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJR05oYmlCdmJteDVJR05oYkd3Z2QyaGxiaUJqY21WaGRHbHVad29nSUNBZ2FXNTBZMTh3SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGJHZHZaR2xqWlM1amIyNTBjbUZqZEM1QmJHZHZaR2xqWlM1eWIyeHNYMkZzZDJGNWMxOXNiM05sS0hCaGVUb2dkV2x1ZERZMEtTQXRQaUJpZVhSbGN6b0tjbTlzYkY5aGJIZGhlWE5mYkc5elpUb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZaR2xqWlM5amIyNTBjbUZqZEM1d2VUb3lNUzB5TWdvZ0lDQWdMeThnUUdGeVl6UXVZV0pwYldWMGFHOWtDaUFnSUNBdkx5QmtaV1lnY205c2JGOWhiSGRoZVhOZmJHOXpaU2h6Wld4bUxDQndZWGs2SUdkMGVHNHVVR0Y1YldWdWRGUnlZVzV6WVdOMGFXOXVLU0F0UGlCVGRISnBibWM2Q2lBZ0lDQndjbTkwYnlBeElERUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZaR2xqWlM5amIyNTBjbUZqZEM1d2VUb3lOQzB5TlFvZ0lDQWdMeThnSXlCV1pYSnBabmtnY0dGNWJXVnVkQ0IwY21GdWMyRmpkR2x2YmdvZ0lDQWdMeThnWVhOelpYSjBJSEJoZVM1elpXNWtaWElnUFQwZ1ZIaHVMbk5sYm1SbGNpd2dJbkJoZVcxbGJuUWdjMlZ1WkdWeUlHMTFjM1FnYldGMFkyZ2dkSEpoYm5OaFkzUnBiMjRnYzJWdVpHVnlJZ29nSUNBZ1puSmhiV1ZmWkdsbklDMHhDaUFnSUNCbmRIaHVjeUJUWlc1a1pYSUtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdjR0Y1YldWdWRDQnpaVzVrWlhJZ2JYVnpkQ0J0WVhSamFDQjBjbUZ1YzJGamRHbHZiaUJ6Wlc1a1pYSUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aGJHZHZaR2xqWlM5amIyNTBjbUZqZEM1d2VUb3lOZ29nSUNBZ0x5OGdZWE56WlhKMElIQmhlUzVoYlc5MWJuUWdQajBnTVRBd01EQXdMQ0FpVFdsdWFXMTFiU0JpWlhRZ2MybDZaU0JwY3lBd0xqRWdRVXhIVHlJS0lDQWdJR1p5WVcxbFgyUnBaeUF0TVFvZ0lDQWdaM1I0Ym5NZ1FXMXZkVzUwQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNVEF3TURBd0NpQWdJQ0ErUFFvZ0lDQWdZWE56WlhKMElDOHZJRTFwYm1sdGRXMGdZbVYwSUhOcGVtVWdhWE1nTUM0eElFRk1SMDhLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhiR2R2WkdsalpTOWpiMjUwY21GamRDNXdlVG95T0FvZ0lDQWdMeThnY21WMGRYSnVJRk4wY21sdVp5Z2lXVzkxSUV4dmMyVWlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSlpiM1VnVEc5elpTSUtJQ0FnSUhKbGRITjFZZ29LQ2k4dklITnRZWEowWDJOdmJuUnlZV04wY3k1aGJHZHZaR2xqWlM1amIyNTBjbUZqZEM1QmJHZHZaR2xqWlM1eWIyeHNYMkZzZDJGNWMxOTNhVzRvY0dGNU9pQjFhVzUwTmpRcElDMCtJR0o1ZEdWek9ncHliMnhzWDJGc2QyRjVjMTkzYVc0NkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVd4bmIyUnBZMlV2WTI5dWRISmhZM1F1Y0hrNk16QXRNekVLSUNBZ0lDOHZJRUJoY21NMExtRmlhVzFsZEdodlpBb2dJQ0FnTHk4Z1pHVm1JSEp2Ykd4ZllXeDNZWGx6WDNkcGJpaHpaV3htTENCd1lYazZJR2QwZUc0dVVHRjViV1Z1ZEZSeVlXNXpZV04wYVc5dUtTQXRQaUJUZEhKcGJtYzZDaUFnSUNCd2NtOTBieUF4SURFS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlpHbGpaUzlqYjI1MGNtRmpkQzV3ZVRvek1pMHpNd29nSUNBZ0x5OGdJeUJXWlhKcFpua2djR0Y1YldWdWRDQjBjbUZ1YzJGamRHbHZiZ29nSUNBZ0x5OGdZWE56WlhKMElIQmhlUzV6Wlc1a1pYSWdQVDBnVkhodUxuTmxibVJsY2l3Z0luQmhlVzFsYm5RZ2MyVnVaR1Z5SUcxMWMzUWdiV0YwWTJnZ2RISmhibk5oWTNScGIyNGdjMlZ1WkdWeUlnb2dJQ0FnWm5KaGJXVmZaR2xuSUMweENpQWdJQ0JuZEhodWN5QlRaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lEMDlDaUFnSUNCaGMzTmxjblFnTHk4Z2NHRjViV1Z1ZENCelpXNWtaWElnYlhWemRDQnRZWFJqYUNCMGNtRnVjMkZqZEdsdmJpQnpaVzVrWlhJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloYkdkdlpHbGpaUzlqYjI1MGNtRmpkQzV3ZVRvek5Bb2dJQ0FnTHk4Z1lYTnpaWEowSUhCaGVTNWhiVzkxYm5RZ1BqMGdNVEF3TURBd0xDQWlUV2x1YVcxMWJTQmlaWFFnYzJsNlpTQnBjeUF3TGpFZ1FVeEhUeUlLSUNBZ0lHWnlZVzFsWDJScFp5QXRNUW9nSUNBZ1ozUjRibk1nUVcxdmRXNTBDaUFnSUNCa2RYQUtJQ0FnSUdsdWRHTmZNU0F2THlBeE1EQXdNREFLSUNBZ0lENDlDaUFnSUNCaGMzTmxjblFnTHk4Z1RXbHVhVzExYlNCaVpYUWdjMmw2WlNCcGN5QXdMakVnUVV4SFR3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGc1oyOWthV05sTDJOdmJuUnlZV04wTG5CNU9qTTFDaUFnSUNBdkx5QnpaVzVrWDJGdGIzVnVkQ0E5SUhCaGVTNWhiVzkxYm5RZ0tpQlZTVzUwTmpRb01pa2dLeUJWU1c1ME5qUW9NVEF3TUNrS0lDQWdJSEIxYzJocGJuUWdNaUF2THlBeUNpQWdJQ0FxQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEF3TUFvZ0lDQWdLd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRnNaMjlrYVdObEwyTnZiblJ5WVdOMExuQjVPak0yQ2lBZ0lDQXZMeUJwZEhodUxsQmhlVzFsYm5Rb1lXMXZkVzUwUFhObGJtUmZZVzF2ZFc1MExDQnlaV05sYVhabGNqMVVlRzR1YzJWdVpHVnlMQ0JtWldVOU1UQXdNQ2t1YzNWaWJXbDBLQ2tLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUhSNGJpQlRaVzVrWlhJS0lDQWdJR2wwZUc1ZlptbGxiR1FnVW1WalpXbDJaWElLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRVzF2ZFc1MENpQWdJQ0JwYm5Salh6QWdMeThnY0dGNUNpQWdJQ0JwZEhodVgyWnBaV3hrSUZSNWNHVkZiblZ0Q2lBZ0lDQnBiblJqWHpJZ0x5OGdNVEF3TUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JHWldVS0lDQWdJR2wwZUc1ZmMzVmliV2wwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjJScFkyVXZZMjl1ZEhKaFkzUXVjSGs2TXpnS0lDQWdJQzh2SUhKbGRIVnliaUJUZEhKcGJtY29JbGx2ZFNCWGFXNGlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSlpiM1VnVjJsdUlnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG1Gc1oyOWthV05sTG1OdmJuUnlZV04wTGtGc1oyOWthV05sTG1obGJHeHZLRzVoYldVNklHSjVkR1Z6S1NBdFBpQmllWFJsY3pvS2FHVnNiRzg2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV3huYjJScFkyVXZZMjl1ZEhKaFkzUXVjSGs2TkRFdE5ESUtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9LUW9nSUNBZ0x5OGdaR1ZtSUdobGJHeHZLSE5sYkdZc0lHNWhiV1U2SUZOMGNtbHVaeWtnTFQ0Z1UzUnlhVzVuT2dvZ0lDQWdjSEp2ZEc4Z01TQXhDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXeG5iMlJwWTJVdlkyOXVkSEpoWTNRdWNIazZORE1LSUNBZ0lDOHZJSEpsZEhWeWJpQWlRV2hoTENBaUlDc2dibUZ0WlFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pCYUdFc0lDSUtJQ0FnSUdaeVlXMWxYMlJwWnlBdE1Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCeVpYUnpkV0lLIiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkNpQURBYUNOQnVnSEpnRUVGUjk4ZFRFYlFRQ0JnZ01FQXdyKzJRVFdhNUc3QkFLK3poRTJHZ0NPQXdCREFDRUFBNEVBUXpFWkZFUXhHRVEyR2dGWEFnQ0lBS3BKRlJaWEJnSk1VQ2hNVUxBaVF6RVpGRVF4R0VReEZpSUpTVGdRSWhKRWlBQllTUlVXVndZQ1RGQW9URkN3SWtNeEdSUkVNUmhFTVJZaUNVazRFQ0lTUklnQUdVa1ZGbGNHQWt4UUtFeFFzQ0pETVJsQS81WXhHQlJFSWtPS0FRR0wvemdBTVFBU1JJdi9PQWdqRDBTQUNGbHZkU0JNYjNObGlZb0JBWXYvT0FBeEFCSkVpLzg0Q0VrakQwU0JBZ3NrQ0xFeEFMSUhzZ2dpc2hBa3NnR3pnQWRaYjNVZ1YybHVpWW9CQVlBRlFXaGhMQ0NMLzFDSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjEwLCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
