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

namespace Arc56.Generated.algorandfoundation.puya_ts.BaseTwo_46813a0e
{


    public class BaseTwoProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public BaseTwoProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> MethodTwo(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 59, 50, 158 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> MethodTwo_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 54, 59, 50, 158 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Because CommonBase implements this method, and MRO for polytype is depth first; this method
        ///should not be accessible from MultiBases as the MRO should be `BaseOne => CommonBase => BaseTwo => CommonBase`
        ///and since CommonBase provides an implementation, this one should not be used
        ///</summary>
        public async Task<string> B2CantOverride(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 245, 20, 44 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> B2CantOverride_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 249, 245, 20, 44 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<string> MethodCommon(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 92, 141, 9 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.String();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToString();

        }

        public async Task<List<Transaction>> MethodCommon_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 69, 92, 141, 9 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQmFzZVR3byIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJtZXRob2RUd28iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJiMkNhbnRPdmVycmlkZSIsImRlc2MiOiJCZWNhdXNlIENvbW1vbkJhc2UgaW1wbGVtZW50cyB0aGlzIG1ldGhvZCwgYW5kIE1STyBmb3IgcG9seXR5cGUgaXMgZGVwdGggZmlyc3Q7IHRoaXMgbWV0aG9kXG5zaG91bGQgbm90IGJlIGFjY2Vzc2libGUgZnJvbSBNdWx0aUJhc2VzIGFzIHRoZSBNUk8gc2hvdWxkIGJlIGBCYXNlT25lID0+IENvbW1vbkJhc2UgPT4gQmFzZVR3byA9PiBDb21tb25CYXNlYFxuYW5kIHNpbmNlIENvbW1vbkJhc2UgcHJvdmlkZXMgYW4gaW1wbGVtZW50YXRpb24sIHRoaXMgb25lIHNob3VsZCBub3QgYmUgdXNlZCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6Im1ldGhvZENvbW1vbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeENpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1UVXhaamRqTnpVZ0ltSmhjMlV0ZEhkdklnb2dJQ0FnWWlCdFlXbHVYMkpzYjJOclFEQUtDbTFoYVc1ZllteHZZMnRBTURvS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaWJub2diV0ZwYmw5aFpuUmxjbDlwWmw5bGJITmxRRElLSUNBZ0lHSWdiV0ZwYmw5cFpsOWliMlI1UURFS0NtMWhhVzVmYVdaZlltOWtlVUF4T2dvZ0lDQWdZMkZzYkhOMVlpQmpiMjV6ZEhKMVkzUnZjZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNZ29LYldGcGJsOWhablJsY2w5cFpsOWxiSE5sUURJNkNpQWdJQ0JpSUcxaGFXNWZZbXh2WTJ0QU13b0tiV0ZwYmw5aWJHOWphMEF6T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZNamtLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCQ1lYTmxWSGR2SUdWNGRHVnVaSE1nUTI5dGJXOXVRbUZ6WlNCN0NpQWdJQ0IwZUc0Z1RuVnRRWEJ3UVhKbmN3b2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJQ0U5Q2lBZ0lDQmllaUJ0WVdsdVgxOWZZV3huYjNSelgxOHVaR1ZtWVhWc2RFTnlaV0YwWlVBeE1nb2dJQ0FnWWlCdFlXbHVYMkZpYVY5eWIzVjBhVzVuUURRS0NtMWhhVzVmWVdKcFgzSnZkWFJwYm1kQU5Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pJNUNpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdRbUZ6WlZSM2J5QmxlSFJsYm1SeklFTnZiVzF2YmtKaGMyVWdld29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdhVzUwWTE4d0lDOHZJRTV2VDNBS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnSVQwS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTVRBS0lDQWdJR0lnYldGcGJsOWpZV3hzWDA1dlQzQkFOUW9LYldGcGJsOWpZV3hzWDA1dlQzQkFOVG9LSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qSTVDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUW1GelpWUjNieUJsZUhSbGJtUnpJRU52YlcxdmJrSmhjMlVnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TXpZellqTXlPV1VnTHk4Z2JXVjBhRzlrSUNKdFpYUm9iMlJVZDI4b0tYTjBjbWx1WnlJS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdZNVpqVXhOREpqSUM4dklHMWxkR2h2WkNBaVlqSkRZVzUwVDNabGNuSnBaR1VvS1hOMGNtbHVaeUlLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFExTldNNFpEQTVJQzh2SUcxbGRHaHZaQ0FpYldWMGFHOWtRMjl0Ylc5dUtDbHpkSEpwYm1jaUNpQWdJQ0IxYm1OdmRtVnlJRE1LSUNBZ0lHMWhkR05vSUcxaGFXNWZiV1YwYUc5a1ZIZHZYM0p2ZFhSbFFEWWdiV0ZwYmw5aU1rTmhiblJQZG1WeWNtbGtaVjl5YjNWMFpVQTNJRzFoYVc1ZmJXVjBhRzlrUTI5dGJXOXVYM0p2ZFhSbFFEZ0tJQ0FnSUdJZ2JXRnBibDl6ZDJsMFkyaGZZMkZ6WlY5dVpYaDBRRGtLQ20xaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTVPZ29nSUNBZ1lpQnRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNVEVLQ20xaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeE1Ub0tJQ0FnSUdJZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXpDZ3B0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTVRNNkNpQWdJQ0F2THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem95T1FvZ0lDQWdMeThnWlhod2IzSjBJR05zWVhOeklFSmhjMlZVZDI4Z1pYaDBaVzVrY3lCRGIyMXRiMjVDWVhObElIc0tJQ0FnSUdWeWNnb0tiV0ZwYmw5dFpYUm9iMlJEYjIxdGIyNWZjbTkxZEdWQU9Eb0tJQ0FnSUM4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pFekNpQWdJQ0F2THlCdFpYUm9iMlJEYjIxdGIyNG9LU0I3Q2lBZ0lDQmpZV3hzYzNWaUlHMWxkR2h2WkVOdmJXMXZiZ29nSUNBZ1lpQnRZV2x1WDNOM2FYUmphRjlqWVhObFgyNWxlSFJBT1FvS2JXRnBibDlpTWtOaGJuUlBkbVZ5Y21sa1pWOXliM1YwWlVBM09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02TkRBS0lDQWdJQzh2SUdJeVEyRnVkRTkyWlhKeWFXUmxLQ2s2SUhOMGNtbHVaeUI3Q2lBZ0lDQmpZV3hzYzNWaUlHSXlRMkZ1ZEU5MlpYSnlhV1JsQ2lBZ0lDQmlJRzFoYVc1ZmMzZHBkR05vWDJOaGMyVmZibVY0ZEVBNUNncHRZV2x1WDIxbGRHaHZaRlIzYjE5eWIzVjBaVUEyT2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZNekVLSUNBZ0lDOHZJRzFsZEdodlpGUjNieWdwSUhzS0lDQWdJR05oYkd4emRXSWdiV1YwYUc5a1ZIZHZDaUFnSUNCaUlHMWhhVzVmYzNkcGRHTm9YMk5oYzJWZmJtVjRkRUE1Q2dwdFlXbHVYMk55WldGMFpWOU9iMDl3UURFd09nb2dJQ0FnWWlCdFlXbHVYMkZtZEdWeVgybG1YMlZzYzJWQU1URUtDbTFoYVc1ZlgxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsUURFeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02TWprS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkNZWE5sVkhkdklHVjRkR1Z1WkhNZ1EyOXRiVzl1UW1GelpTQjdDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdUbTlQY0FvZ0lDQWdQVDBLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdQVDBLSUNBZ0lDWW1DaUFnSUNCaGMzTmxjblFLSUNBZ0lHTmhiR3h6ZFdJZ1gxOWhiR2R2ZEhOZlh5NWtaV1poZFd4MFEzSmxZWFJsQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2dvS0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rSmhjMlZVZDI4dWJXVjBhRzlrVkhkdlczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0tiV1YwYUc5a1ZIZHZPZ29nSUNBZ1lpQnRaWFJvYjJSVWQyOWZZbXh2WTJ0QU1Bb0tiV1YwYUc5a1ZIZHZYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvek1Rb2dJQ0FnTHk4Z2JXVjBhRzlrVkhkdktDa2dld29nSUNBZ1kyRnNiSE4xWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UW1GelpWUjNieTV0WlhSb2IyUlVkMjhLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwQ1lYTmxWSGR2TG1JeVEyRnVkRTkyWlhKeWFXUmxXM0p2ZFhScGJtZGRLQ2tnTFQ0Z2RtOXBaRG9LWWpKRFlXNTBUM1psY25KcFpHVTZDaUFnSUNCaUlHSXlRMkZ1ZEU5MlpYSnlhV1JsWDJKc2IyTnJRREFLQ21JeVEyRnVkRTkyWlhKeWFXUmxYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvME1Bb2dJQ0FnTHk4Z1lqSkRZVzUwVDNabGNuSnBaR1VvS1RvZ2MzUnlhVzVuSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rSmhjMlZVZDI4dVlqSkRZVzUwVDNabGNuSnBaR1VLSUNBZ0lHUjFjQW9nSUNBZ2JHVnVDaUFnSUNCcGRHOWlDaUFnSUNCbGVIUnlZV04wSURZZ01nb2dJQ0FnZFc1amIzWmxjaUF4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdkVzVqYjNabGNpQXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LQ2k4dklIUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwRGIyMXRiMjVDWVhObExtMWxkR2h2WkVOdmJXMXZibHR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q20xbGRHaHZaRU52YlcxdmJqb0tJQ0FnSUdJZ2JXVjBhRzlrUTI5dGJXOXVYMkpzYjJOclFEQUtDbTFsZEdodlpFTnZiVzF2Ymw5aWJHOWphMEF3T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZNVE1LSUNBZ0lDOHZJRzFsZEdodlpFTnZiVzF2YmlncElIc0tJQ0FnSUdOaGJHeHpkV0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa052YlcxdmJrSmhjMlV1YldWMGFHOWtRMjl0Ylc5dUNpQWdJQ0JrZFhBS0lDQWdJR3hsYmdvZ0lDQWdhWFJ2WWdvZ0lDQWdaWGgwY21GamRDQTJJRElLSUNBZ0lIVnVZMjkyWlhJZ01Rb2dJQ0FnWTI5dVkyRjBDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhWdVkyOTJaWElnTVFvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6bzZRbUZ6WlZSM2J5NXRaWFJvYjJSVWQyOG9LU0F0UGlCaWVYUmxjem9LZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa0poYzJWVWQyOHViV1YwYUc5a1ZIZHZPZ29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlFtRnpaVlIzYnk1dFpYUm9iMlJVZDI5ZllteHZZMnRBTUFvS2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02T2tKaGMyVlVkMjh1YldWMGFHOWtWSGR2WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6b3pNZ29nSUNBZ0x5OGdjbVYwZFhKdUlDZGlZWE5sTFhSM2J5Y0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltSmhjMlV0ZEhkdklnb2dJQ0FnY21WMGMzVmlDZ29LTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02T2tKaGMyVlVkMjh1WWpKRFlXNTBUM1psY25KcFpHVW9LU0F0UGlCaWVYUmxjem9LZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa0poYzJWVWQyOHVZakpEWVc1MFQzWmxjbkpwWkdVNkNpQWdJQ0JpSUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBDWVhObFZIZHZMbUl5UTJGdWRFOTJaWEp5YVdSbFgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwQ1lYTmxWSGR2TG1JeVEyRnVkRTkyWlhKeWFXUmxYMkpzYjJOclFEQTZDaUFnSUNBdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvME1Rb2dJQ0FnTHk4Z2NtVjBkWEp1SUNkaVlYTmxMWFIzYnljS0lDQWdJR0o1ZEdWalh6RWdMeThnSW1KaGMyVXRkSGR2SWdvZ0lDQWdjbVYwYzNWaUNnb0tMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa052YlcxdmJrSmhjMlV1YldWMGFHOWtRMjl0Ylc5dUtDa2dMVDRnWW5sMFpYTTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcERiMjF0YjI1Q1lYTmxMbTFsZEdodlpFTnZiVzF2YmpvS0lDQWdJR0lnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZPa052YlcxdmJrSmhjMlV1YldWMGFHOWtRMjl0Ylc5dVgySnNiMk5yUURBS0NuUmxjM1J6TDJGd2NISnZkbUZzY3k5dGRXeDBhUzFwYm1obGNtbDBZVzVqWlM1aGJHZHZMblJ6T2pwRGIyMXRiMjVDWVhObExtMWxkR2h2WkVOdmJXMXZibDlpYkc5amEwQXdPZ29nSUNBZ0x5OGdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk1UUUtJQ0FnSUM4dklISmxkSFZ5YmlBblkyOXRiVzl1SndvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pqYjIxdGIyNGlDaUFnSUNCeVpYUnpkV0lLQ2dvdkx5QjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlFtRnpaVlIzYnk1ZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1VvS1NBdFBpQjJiMmxrT2dwZlgyRnNaMjkwYzE5ZkxtUmxabUYxYkhSRGNtVmhkR1U2Q2lBZ0lDQmlJRjlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpWOWliRzlqYTBBd0NncGZYMkZzWjI5MGMxOWZMbVJsWm1GMWJIUkRjbVZoZEdWZllteHZZMnRBTURvS0lDQWdJSEpsZEhOMVlnb0tDaTh2SUhSbGMzUnpMMkZ3Y0hKdmRtRnNjeTl0ZFd4MGFTMXBibWhsY21sMFlXNWpaUzVoYkdkdkxuUnpPanBDWVhObFZIZHZMbU52Ym5OMGNuVmpkRzl5S0NrZ0xUNGdkbTlwWkRvS1kyOXVjM1J5ZFdOMGIzSTZDaUFnSUNCaUlHTnZibk4wY25WamRHOXlYMkpzYjJOclFEQUtDbU52Ym5OMGNuVmpkRzl5WDJKc2IyTnJRREE2Q2lBZ0lDQXZMeUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6b3lPUW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVKaGMyVlVkMjhnWlhoMFpXNWtjeUJEYjIxdGIyNUNZWE5sSUhzS0lDQWdJR05oYkd4emRXSWdkR1Z6ZEhNdllYQndjbTkyWVd4ekwyMTFiSFJwTFdsdWFHVnlhWFJoYm1ObExtRnNaMjh1ZEhNNk9rTnZiVzF2YmtKaGMyVXVZMjl1YzNSeWRXTjBiM0lLSUNBZ0lDOHZJSFJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QnpkR0YwWlZSM2J5QTlJRWRzYjJKaGJGTjBZWFJsS0hzZ2FXNXBkR2xoYkZaaGJIVmxPaUFuU0dWc2JHOG5JSDBwQ2lBZ0lDQndkWE5vWW5sMFpYTWdJbk4wWVhSbFZIZHZJZ29nSUNBZ2NIVnphR0o1ZEdWeklDSklaV3hzYnlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUtDZ292THlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UTI5dGJXOXVRbUZ6WlM1amIyNXpkSEoxWTNSdmNpZ3BJQzArSUhadmFXUTZDblJsYzNSekwyRndjSEp2ZG1Gc2N5OXRkV3gwYVMxcGJtaGxjbWwwWVc1alpTNWhiR2R2TG5Sek9qcERiMjF0YjI1Q1lYTmxMbU52Ym5OMGNuVmpkRzl5T2dvZ0lDQWdZaUIwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6bzZRMjl0Ylc5dVFtRnpaUzVqYjI1emRISjFZM1J2Y2w5aWJHOWphMEF3Q2dwMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UTI5dGJXOXVRbUZ6WlM1amIyNXpkSEoxWTNSdmNsOWliRzlqYTBBd09nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02TVRBS0lDQWdJQzh2SUdWNGNHOXlkQ0JqYkdGemN5QkRiMjF0YjI1Q1lYTmxJR1Y0ZEdWdVpITWdRMjl1ZEhKaFkzUWdld29nSUNBZ1lpQjBaWE4wY3k5aGNIQnliM1poYkhNdmJYVnNkR2t0YVc1b1pYSnBkR0Z1WTJVdVlXeG5ieTUwY3pvNlEyOXRiVzl1UW1GelpTNWpiMjV6ZEhKMVkzUnZjbDlpYkc5amEwQXhDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6bzZRMjl0Ylc5dVFtRnpaUzVqYjI1emRISjFZM1J2Y2w5aWJHOWphMEF4T2dvZ0lDQWdMeThnZEdWemRITXZZWEJ3Y205MllXeHpMMjExYkhScExXbHVhR1Z5YVhSaGJtTmxMbUZzWjI4dWRITTZNVEFLSUNBZ0lDOHZJR1Y0Y0c5eWRDQmpiR0Z6Y3lCRGIyMXRiMjVDWVhObElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnWWlCMFpYTjBjeTloY0hCeWIzWmhiSE12YlhWc2RHa3RhVzVvWlhKcGRHRnVZMlV1WVd4bmJ5NTBjem82UTI5dGJXOXVRbUZ6WlM1amIyNXpkSEoxWTNSdmNsOWhablJsY2w5cGJteHBibVZrWDBCaGJHZHZjbUZ1WkdadmRXNWtZWFJwYjI0dllXeG5iM0poYm1RdGRIbHdaWE5qY21sd2RDOWlZWE5sTFdOdmJuUnlZV04wTG1RdWRITTZPa0poYzJWRGIyNTBjbUZqZEM1amIyNXpkSEoxWTNSdmNrQXlDZ3AwWlhOMGN5OWhjSEJ5YjNaaGJITXZiWFZzZEdrdGFXNW9aWEpwZEdGdVkyVXVZV3huYnk1MGN6bzZRMjl0Ylc5dVFtRnpaUzVqYjI1emRISjFZM1J2Y2w5aFpuUmxjbDlwYm14cGJtVmtYMEJoYkdkdmNtRnVaR1p2ZFc1a1lYUnBiMjR2WVd4bmIzSmhibVF0ZEhsd1pYTmpjbWx3ZEM5aVlYTmxMV052Ym5SeVlXTjBMbVF1ZEhNNk9rSmhjMlZEYjI1MGNtRmpkQzVqYjI1emRISjFZM1J2Y2tBeU9nb2dJQ0FnTHk4Z2RHVnpkSE12WVhCd2NtOTJZV3h6TDIxMWJIUnBMV2x1YUdWeWFYUmhibU5sTG1Gc1oyOHVkSE02TVRFS0lDQWdJQzh2SUhOMFlYUmxRMjl0Ylc5dUlEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dNVEl6SUgwcENpQWdJQ0J3ZFhOb1lubDBaWE1nSW5OMFlYUmxRMjl0Ylc5dUlnb2dJQ0FnY0hWemFHbHVkQ0F4TWpNS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0J5WlhSemRXSUsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCaUlHMWhhVzVmWW14dlkydEFNQW9LYldGcGJsOWliRzlqYTBBd09nb2dJQ0FnY0hWemFHbHVkQ0F4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBQUVtQWdRVkgzeDFDR0poYzJVdGRIZHZRZ0FBTVJoQUFBbENBQUNJQU1oQ0FBQkNBQUF4R3lJVFFRQlFRZ0FBTVJraUVrUXhHQ0lUUVFBK1FnQUFOaG9BZ0FRMk96S2VnQVQ1OVJRc2dBUkZYSTBKVHdPT0F3QVdBQkFBQ2tJQUFFSUFBRUlBQUFDSUFFMUMvL09JQURGQy8rMklBQlZDLytkQy8rY3hHU0lTTVJnaUVoQkVpQUJhSTBOQ0FBQ0lBRHhKRlJaWEJnSlBBVkFvVHdGUXNDTkRRZ0FBaUFBclNSVVdWd1lDVHdGUUtFOEJVTEFqUTBJQUFJZ0FHa2tWRmxjR0FrOEJVQ2hQQVZDd0kwTkNBQUFwaVVJQUFDbUpRZ0FBZ0FaamIyMXRiMjZKUWdBQWlVSUFBSWdBRTRBSWMzUmhkR1ZVZDIrQUJVaGxiR3h2WjRsQ0FBQkNBQUJDQUFDQUMzTjBZWFJsUTI5dGJXOXVnWHRuaVE9PSIsImNsZWFyIjoiQzBJQUFJRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
