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

namespace Arc56.Generated.Argimirodelpozo.puya_sol.C_8e68ad1c
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
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> F(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 120, 179, 84 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> F_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 205, 120, 179, 84 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task G(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 182, 95, 39 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> G_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 242, 182, 95, 39 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt256> H(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 237, 178, 229 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt256();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> H_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 175, 237, 178, 229 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task<AVM.ClientGenerator.ABI.ARC4.Types.UInt512> X(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 74, 189, 253 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt512();
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj;

        }

        public async Task<List<Transaction>> X_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 63, 74, 189, 253 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJmIiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQyNTYiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImciLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiaCIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50MjU2Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJ4IiwiZGVzYyI6bnVsbCwiYXJncyI6W10sInJldHVybnMiOnsidHlwZSI6InVpbnQ1MTIiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjAsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsyMzksMzYxLDQ4MCw1OTFdLCJlcnJvck1lc3NhZ2UiOiJub3QgcGF5YWJsZSIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzIwMiwzMTAsNTQ1XSwiZXJyb3JNZXNzYWdlIjoib3ZlcmZsb3ciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0MDZdLCJlcnJvck1lc3NhZ2UiOiJzaWduZWQgYXJpdGhtZXRpYyBvdmVyZmxvdyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12WjJWMGRHVnljeTkwY21GdWMybGxiblJmZG1Gc2RXVmZkSGx3WlhOZmJYVnNkR2xmWm5KaGJXVmZZMkZzYkM1emIyd3VReTVoY0hCeWIzWmhiRjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2FXNTBZMkpzYjJOcklEZ2dNU0F6TVNBd0NpQWdJQ0JpZVhSbFkySnNiMk5ySURCNE1ERXdNQ0F3ZUdabUlEQjRPREFnTUhneE5URm1OMk0zTlNBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abU1EQWdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBZ01IZ3dNUW9nSUNBZ2NIVnphR2x1ZENBME1EazJDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCemRHOXlaU0ExQ2lBZ0lDQnpkRzl5WlNBd0NpQWdJQ0JzYjJGa0lEQUtJQ0FnSUhCMWMyaGllWFJsY3lBd2VEQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd09EQUtJQ0FnSUhKbGNHeGhZMlV5SURZMENpQWdJQ0J6ZEc5eVpTQXdDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0J3ZFhOb1lubDBaWE1nSW5naUNpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWVhOelpYSjBDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZMlEzT0dJek5UUWdNSGhtTW1JMk5XWXlOeUF3ZUdGbVpXUmlNbVUxSURCNE0yWTBZV0prWm1RZ0x5OGdiV1YwYUc5a0lDSm1LQ2wxYVc1ME1qVTJJaXdnYldWMGFHOWtJQ0puS0NsMmIybGtJaXdnYldWMGFHOWtJQ0pvS0NsMWFXNTBNalUySWl3Z2JXVjBhRzlrSUNKNEtDbDFhVzUwTlRFeUlnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2diV0ZwYmw5bVgzSnZkWFJsUURVZ2JXRnBibDluWDNKdmRYUmxRRFlnYldGcGJsOW9YM0p2ZFhSbFFEY2diV0ZwYmw5NFgzSnZkWFJsUURnS0lDQWdJR1Z5Y2dvS2JXRnBibDk0WDNKdmRYUmxRRGc2Q2lBZ0lDQmpZV3hzYzNWaUlIZ0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQThQUW9nSUNBZ1lYTnpaWEowSUM4dklHOTJaWEptYkc5M0NpQWdJQ0J3ZFhOb2FXNTBJRFkwQ2lBZ0lDQmllbVZ5YndvZ0lDQWdZbndLSUNBZ0lHSjVkR1ZqWHpNZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZhRjl5YjNWMFpVQTNPZ29nSUNBZ1kyRnNiSE4xWWlCb0NpQWdJQ0JpZVhSbFkxOHpJQzh2SURCNE1UVXhaamRqTnpVS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnYkc5bkNpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNncHRZV2x1WDJkZmNtOTFkR1ZBTmpvS0lDQWdJR05oYkd4emRXSWdad29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUhKbGRIVnliZ29LYldGcGJsOW1YM0p2ZFhSbFFEVTZDaUFnSUNCMGVHNGdSM0p2ZFhCSmJtUmxlQW9nSUNBZ1lub2diV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREl3Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREl4T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCc2IyRmtJRFVLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCaWVtVnlid29nSUNBZ1pIVndDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhobVpnb2dJQ0FnY21Wd2JHRmpaVElnTXpFS0lDQWdJSE4wYjNKbElEVUtJQ0FnSUdOaGJHeHpkV0lnYUFvZ0lDQWdaR2xuSURFS0lDQWdJSE4zWVhBS0lDQWdJR052Ym1OaGRBb2dJQ0FnWTJGc2JITjFZaUJvQ2lBZ0lDQjFibU52ZG1WeUlESUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHVnVDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnTFFvZ0lDQWdhVzUwWTE4d0lDOHZJRGdLSUNBZ0lHVjRkSEpoWTNRekNpQWdJQ0JpZVhSbFkxOHhJQzh2SURCNFptWUtJQ0FnSUdJbUNpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE9EQUtJQ0FnSUdJK1BRb2dJQ0FnWW5vZ2JXRnBibDkwWlhKdVlYSjVYMlpoYkhObFFESXpDaUFnSUNCallXeHNjM1ZpSUdnS0lDQWdJR1JwWnlBeENpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUdOaGJHeHpkV0lnYUFvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeGxiZ29nSUNBZ2FXNTBZMTh3SUM4dklEZ0tJQ0FnSUMwS0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQmxlSFJ5WVdOME13b2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VHWm1DaUFnSUNCaUpnb2dJQ0FnWW5sMFpXTWdOQ0F2THlBd2VHWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abU1EQUtJQ0FnSUdJckNpQWdJQ0JpZVhSbFl5QTFJQzh2SURCNE1ERXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdDaUFnSUNCaUpRb0tiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREkwT2dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tiV0ZwYmw5MFpYSnVZWEo1WDJaaGJITmxRREl6T2dvZ0lDQWdZMkZzYkhOMVlpQm9DaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpZV3hzYzNWaUlHZ0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGhtWmdvZ0lDQWdZaVlLSUNBZ0lHSWdiV0ZwYmw5MFpYSnVZWEo1WDIxbGNtZGxRREkwQ2dwdFlXbHVYM1JsY201aGNubGZabUZzYzJWQU1qQTZDaUFnSUNCcGJuUmpYek1nTHk4Z01Bb2dJQ0FnWWlCdFlXbHVYM1JsY201aGNubGZiV1Z5WjJWQU1qRUtDZ292THlBdmFHOXRaUzloY21kcEwwRnNaMjl5WVc1a1JtOTFibVJoZEdsdmJpOVRhV1JsVUhKdmFtVmpkSE12Y0hWNVlTMXpiMnd2Y0hWNVlTMXpiMnd2ZEdWemRITXZjMjlzYVdScGRIa3RjMlZ0WVc1MGFXTXRkR1Z6ZEhNdmRHVnpkSE12WjJWMGRHVnljeTkwY21GdWMybGxiblJmZG1Gc2RXVmZkSGx3WlhOZmJYVnNkR2xmWm5KaGJXVmZZMkZzYkM1emIyd3VReTVuS0NrZ0xUNGdkbTlwWkRvS1p6b0tJQ0FnSUhSNGJpQkhjbTkxY0VsdVpHVjRDaUFnSUNCaWVpQm5YM1JsY201aGNubGZabUZzYzJWQU1nb2dJQ0FnZEhodUlFZHliM1Z3U1c1a1pYZ0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0F0Q2lBZ0lDQm5kSGh1Y3lCQmJXOTFiblFLQ21kZmRHVnlibUZ5ZVY5dFpYSm5aVUF6T2dvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHNXZkQ0J3WVhsaFlteGxDaUFnSUNCc2IyRmtJRFVLSUNBZ0lHbHVkR05mTWlBdkx5QXpNUW9nSUNBZ1oyVjBZbmwwWlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFkxOHlJQzh2SURCNE9EQUtJQ0FnSUdJOENpQWdJQ0JpYm5vZ1oxOWliMjlzWDNSeWRXVkFOUW9nSUNBZ2JHOWhaQ0ExQ2lBZ0lDQnBiblJqWHpJZ0x5OGdNekVLSUNBZ0lHZGxkR0o1ZEdVS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6QWdMeThnTUhnd01UQXdDaUFnSUNCaUpRb2dJQ0FnWW5sMFpXTmZNaUF2THlBd2VEZ3dDaUFnSUNCaVBBb2dJQ0FnSVFvZ0lDQWdiRzloWkNBMUNpQWdJQ0JwYm5Salh6SWdMeThnTXpFS0lDQWdJR2RsZEdKNWRHVUtJQ0FnSUdsMGIySUtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3Q2lBZ0lDQmlKUW9nSUNBZ1lubDBaV05mTUNBdkx5QXdlREF4TURBS0lDQWdJR0lyQ2lBZ0lDQmllWFJsWXlBMklDOHZJREI0TURFS0lDQWdJR0l0Q2lBZ0lDQmllWFJsWTE4d0lDOHZJREI0TURFd01Bb2dJQ0FnWWlVS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnNE1Bb2dJQ0FnWWp3S0lDQWdJQ0VLSUNBZ0lEMDlDaUFnSUNCaWVpQm5YMkp2YjJ4ZlptRnNjMlZBTmdvS1oxOWliMjlzWDNSeWRXVkFOVG9LSUNBZ0lHbHVkR05mTVNBdkx5QXhDZ3BuWDJKdmIyeGZiV1Z5WjJWQU56b0tJQ0FnSUdGemMyVnlkQ0F2THlCemFXZHVaV1FnWVhKcGRHaHRaWFJwWXlCdmRtVnlabXh2ZHdvZ0lDQWdiRzloWkNBMUNpQWdJQ0JwYm5Salh6QWdMeThnT0FvZ0lDQWdZbnBsY204S0lDQWdJR3h2WVdRZ05Rb2dJQ0FnYVc1MFkxOHlJQzh2SURNeENpQWdJQ0JuWlhSaWVYUmxDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh3SUM4dklEQjRNREV3TUFvZ0lDQWdZaVVLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdNSGd3TVRBd0NpQWdJQ0JpS3dvZ0lDQWdZbmwwWldNZ05pQXZMeUF3ZURBeENpQWdJQ0JpTFFvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQUtJQ0FnSUdJbENpQWdJQ0JrYVdjZ01Rb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc2IyRmtJRFVLSUNBZ0lHbHVkR05mTWlBdkx5QXpNUW9nSUNBZ1oyVjBZbmwwWlFvZ0lDQWdhWFJ2WWdvZ0lDQWdZbmwwWldOZk1DQXZMeUF3ZURBeE1EQUtJQ0FnSUdJbENpQWdJQ0JpZVhSbFkxOHdJQzh2SURCNE1ERXdNQW9nSUNBZ1lpc0tJQ0FnSUdKNWRHVmpJRFlnTHk4Z01IZ3dNUW9nSUNBZ1lpMEtJQ0FnSUdKNWRHVmpYekFnTHk4Z01IZ3dNVEF3Q2lBZ0lDQmlKUW9nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4bGJnb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJQzBLSUNBZ0lHbHVkR05mTUNBdkx5QTRDaUFnSUNCbGVIUnlZV04wTXdvZ0lDQWdaWGgwY21GamRDQTNJREVLSUNBZ0lISmxjR3hoWTJVeUlETXhDaUFnSUNCemRHOXlaU0ExQ2lBZ0lDQnlaWFJ6ZFdJS0NtZGZZbTl2YkY5bVlXeHpaVUEyT2dvZ0lDQWdhVzUwWTE4eklDOHZJREFLSUNBZ0lHSWdaMTlpYjI5c1gyMWxjbWRsUURjS0NtZGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBeU9nb2dJQ0FnYVc1MFkxOHpJQzh2SURBS0lDQWdJR0lnWjE5MFpYSnVZWEo1WDIxbGNtZGxRRE1LQ2dvdkx5QXZhRzl0WlM5aGNtZHBMMEZzWjI5eVlXNWtSbTkxYm1SaGRHbHZiaTlUYVdSbFVISnZhbVZqZEhNdmNIVjVZUzF6YjJ3dmNIVjVZUzF6YjJ3dmRHVnpkSE12YzI5c2FXUnBkSGt0YzJWdFlXNTBhV010ZEdWemRITXZkR1Z6ZEhNdloyVjBkR1Z5Y3k5MGNtRnVjMmxsYm5SZmRtRnNkV1ZmZEhsd1pYTmZiWFZzZEdsZlpuSmhiV1ZmWTJGc2JDNXpiMnd1UXk1b0tDa2dMVDRnWW5sMFpYTTZDbWc2Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdZbm9nYUY5MFpYSnVZWEo1WDJaaGJITmxRRElLSUNBZ0lIUjRiaUJIY205MWNFbHVaR1Y0Q2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ0xRb2dJQ0FnWjNSNGJuTWdRVzF2ZFc1MENncG9YM1JsY201aGNubGZiV1Z5WjJWQU16b0tJQ0FnSUNFS0lDQWdJR0Z6YzJWeWRDQXZMeUJ1YjNRZ2NHRjVZV0pzWlFvZ0lDQWdZMkZzYkhOMVlpQm5DaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWW5wbGNtOEtJQ0FnSUdSMWNBb2dJQ0FnWTJGc2JITjFZaUI0Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JqWVd4c2MzVmlJSGdLSUNBZ0lIVnVZMjkyWlhJZ01nb2dJQ0FnYzNkaGNBb2dJQ0FnWTI5dVkyRjBDaUFnSUNCc1pXNEtJQ0FnSUdsdWRHTmZNQ0F2THlBNENpQWdJQ0F0Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ1pYaDBjbUZqZERNS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhobVpnb2dJQ0FnWWlZS0lDQWdJR0o1ZEdWalh6SWdMeThnTUhnNE1Bb2dJQ0FnWWo0OUNpQWdJQ0JpZWlCb1gzUmxjbTVoY25sZlptRnNjMlZBTlFvZ0lDQWdZMkZzYkhOMVlpQjRDaUFnSUNCa2FXY2dNUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQmpZV3hzYzNWaUlIZ0tJQ0FnSUhWdVkyOTJaWElnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzWlc0S0lDQWdJR2x1ZEdOZk1DQXZMeUE0Q2lBZ0lDQXRDaUFnSUNCcGJuUmpYekFnTHk4Z09Bb2dJQ0FnWlhoMGNtRmpkRE1LSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGhtWmdvZ0lDQWdZaVlLSUNBZ0lHSjVkR1ZqSURRZ0x5OGdNSGhtWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1aakF3Q2lBZ0lDQmlLd29nSUNBZ1lubDBaV01nTlNBdkx5QXdlREF4TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TUFvZ0lDQWdZaVVLQ21oZmRHVnlibUZ5ZVY5dFpYSm5aVUEyT2dvZ0lDQWdaSFZ3Q2lBZ0lDQnNaVzRLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUR3OUNpQWdJQ0JoYzNObGNuUWdMeThnYjNabGNtWnNiM2NLSUNBZ0lIQjFjMmhwYm5RZ016SUtJQ0FnSUdKNlpYSnZDaUFnSUNCaWZBb2dJQ0FnY21WMGMzVmlDZ3BvWDNSbGNtNWhjbmxmWm1Gc2MyVkFOVG9LSUNBZ0lHTmhiR3h6ZFdJZ2VBb2dJQ0FnWkdsbklERUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ1kyRnNiSE4xWWlCNENpQWdJQ0IxYm1OdmRtVnlJRElLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiR1Z1Q2lBZ0lDQnBiblJqWHpBZ0x5OGdPQW9nSUNBZ0xRb2dJQ0FnYVc1MFkxOHdJQzh2SURnS0lDQWdJR1Y0ZEhKaFkzUXpDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRabVlLSUNBZ0lHSW1DaUFnSUNCaUlHaGZkR1Z5Ym1GeWVWOXRaWEpuWlVBMkNncG9YM1JsY201aGNubGZabUZzYzJWQU1qb0tJQ0FnSUdsdWRHTmZNeUF2THlBd0NpQWdJQ0JpSUdoZmRHVnlibUZ5ZVY5dFpYSm5aVUF6Q2dvS0x5OGdMMmh2YldVdllYSm5hUzlCYkdkdmNtRnVaRVp2ZFc1a1lYUnBiMjR2VTJsa1pWQnliMnBsWTNSekwzQjFlV0V0YzI5c0wzQjFlV0V0YzI5c0wzUmxjM1J6TDNOdmJHbGthWFI1TFhObGJXRnVkR2xqTFhSbGMzUnpMM1JsYzNSekwyZGxkSFJsY25NdmRISmhibk5wWlc1MFgzWmhiSFZsWDNSNWNHVnpYMjExYkhScFgyWnlZVzFsWDJOaGJHd3VjMjlzTGtNdWVDZ3BJQzArSUdKNWRHVnpPZ3A0T2dvZ0lDQWdkSGh1SUVkeWIzVndTVzVrWlhnS0lDQWdJR0o2SUhoZmRHVnlibUZ5ZVY5bVlXeHpaVUF5Q2lBZ0lDQjBlRzRnUjNKdmRYQkpibVJsZUFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDMEtJQ0FnSUdkMGVHNXpJRUZ0YjNWdWRBb0tlRjkwWlhKdVlYSjVYMjFsY21kbFFETTZDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnYm05MElIQmhlV0ZpYkdVS0lDQWdJR3h2WVdRZ05Rb2dJQ0FnYVc1MFkxOHlJQzh2SURNeENpQWdJQ0JuWlhSaWVYUmxDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh4SUM4dklEQjRabVlLSUNBZ0lHSW1DaUFnSUNCaWVYUmxZMTh5SUM4dklEQjRPREFLSUNBZ0lHSStQUW9nSUNBZ1lub2dlRjkwWlhKdVlYSjVYMlpoYkhObFFEVUtJQ0FnSUd4dllXUWdOUW9nSUNBZ2FXNTBZMTh5SUM4dklETXhDaUFnSUNCblpYUmllWFJsQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0Wm1ZS0lDQWdJR0ltQ2lBZ0lDQmllWFJsWXlBMElDOHZJREI0Wm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVptWm1abVl3TUFvZ0lDQWdZaXNLSUNBZ0lHSjVkR1ZqSURVZ0x5OGdNSGd3TVRBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBd01EQXdNREF3TURBS0lDQWdJR0lsQ2lBZ0lDQnlaWFJ6ZFdJS0NuaGZkR1Z5Ym1GeWVWOW1ZV3h6WlVBMU9nb2dJQ0FnYkc5aFpDQTFDaUFnSUNCcGJuUmpYeklnTHk4Z016RUtJQ0FnSUdkbGRHSjVkR1VLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGhtWmdvZ0lDQWdZaVlLSUNBZ0lISmxkSE4xWWdvS2VGOTBaWEp1WVhKNVgyWmhiSE5sUURJNkNpQWdJQ0JwYm5Salh6TWdMeThnTUFvZ0lDQWdZaUI0WDNSbGNtNWhjbmxmYldWeVoyVkFNd289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUF2YUc5dFpTOWhjbWRwTDBGc1oyOXlZVzVrUm05MWJtUmhkR2x2Ymk5VGFXUmxVSEp2YW1WamRITXZjSFY1WVMxemIyd3ZjSFY1WVMxemIyd3ZkR1Z6ZEhNdmMyOXNhV1JwZEhrdGMyVnRZVzUwYVdNdGRHVnpkSE12ZEdWemRITXZaMlYwZEdWeWN5OTBjbUZ1YzJsbGJuUmZkbUZzZFdWZmRIbHdaWE5mYlhWc2RHbGZabkpoYldWZlkyRnNiQzV6YjJ3dVF5NWpiR1ZoY2w5emRHRjBaVjl3Y205bmNtRnRLQ2tnTFQ0Z2RXbHVkRFkwT2dwdFlXbHVPZ29nSUNBZ2NIVnphR2x1ZENBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFFQ0FFZkFDWUhBZ0VBQWY4QmdBUVZIM3gxSVAvLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vLy8vOEFJUUVBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBRUJnWUFncjBrMUJUVUFOQUNBSUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQUFBQ0FYRUExQURFWVFBQUhnQUY0SldjalF6RVpGRVF4R0VTQ0JBVE5lTE5VQlBLMlh5Y0VyKzJ5NVFRL1NyMzlOaG9BamdRQUlnQWRBQlFBQVFDSUFYNUpGWUZBRGtTQlFLK3JLMHhRc0NORGlBRDhLMHhRc0NORGlBQjhJME14RmtFQWNURVdJd2s0Q0JSRU5BVWlyMGxQQWlsY0h6VUZpQURWU3dGTVVJZ0F6azhDVEZBVklna2lXQ21zS3FkQkFDdUlBTHRMQVV4UWlBQzBUd0pNVUJVaUNTSllLYXduQktBbkJhcEpGWUVnRGtTQklLK3JLMHhRc0NORGlBQ1FTd0ZNVUlnQWlVOENURkFWSWdraVdDbXNRdi9ZSlVML2tURVdRUUJ1TVJZakNUZ0lGRVEwQlNSVkZpaXFLcVJBQUI4MEJTUlZGaWlxS3FRVU5BVWtWUllvcWlpZ0p3YWhLS29xcEJRU1FRQTNJMFEwQlNLdk5BVWtWUllvcWlpZ0p3YWhLS3BMQVV4UU5BVWtWUllvcWlpZ0p3YWhLS3BQQWt4UUZTSUpJbGhYQndGY0h6VUZpU1ZDLzhZbFF2K1VNUlpCQUdZeEZpTUpPQWdVUklqL2VTS3ZTWWdBV1VzQlRGQ0lBRkpQQWt4UUZTSUpJbGdwckNxblFRQW1pQUEvU3dGTVVJZ0FPRThDVEZBVklna2lXQ21zSndTZ0p3V3FTUldCSUE1RWdTQ3ZxNG1JQUJsTEFVeFFpQUFTVHdKTVVCVWlDU0pZS2F4Qy85MGxRditjTVJaQkFDb3hGaU1KT0FnVVJEUUZKRlVXS2F3cXAwRUFEalFGSkZVV0thd25CS0FuQmFxSk5BVWtWUllwcklrbFF2L1kiLCJjbGVhciI6IkNvRUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo4LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
