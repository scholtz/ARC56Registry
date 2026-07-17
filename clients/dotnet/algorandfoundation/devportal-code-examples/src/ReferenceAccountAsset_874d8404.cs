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

namespace Arc56.Generated.algorandfoundation.devportal_code_examples.ReferenceAccountAsset_874d8404
{


    //
    // 
    //    Returns the balance of a specific asset in a hardcoded account
    //    @returns The asset balance of the account
    //    
    //
    public class ReferenceAccountAssetProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public ReferenceAccountAssetProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> GetAssetBalance(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 94, 123, 150 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAssetBalance_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 166, 94, 123, 150 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="acct"> </param>
        /// <param name="asset"> </param>
        public async Task<ulong> GetAssetBalanceWithArg(Algorand.Address acct, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 108, 254, 93 };
            var acctAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); acctAbi.From(acct);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            var result = await base.CallApp(new List<object> { abiHandle, acctAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetAssetBalanceWithArg_Transactions(Algorand.Address acct, ulong asset, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 11, 108, 254, 93 };
            var acctAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); acctAbi.From(acct);
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);

            return await base.MakeTransactionList(new List<object> { abiHandle, acctAbi, assetAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUmVmZXJlbmNlQWNjb3VudEFzc2V0IiwiZGVzYyI6IlxuICAgIFJldHVybnMgdGhlIGJhbGFuY2Ugb2YgYSBzcGVjaWZpYyBhc3NldCBpbiBhIGhhcmRjb2RlZCBhY2NvdW50XG4gICAgQHJldHVybnMgVGhlIGFzc2V0IGJhbGFuY2Ugb2YgdGhlIGFjY291bnRcbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoiZ2V0X2Fzc2V0X2JhbGFuY2UiLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJnZXRfYXNzZXRfYmFsYW5jZV93aXRoX2FyZyIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJhZGRyZXNzIiwic3RydWN0IjpudWxsLCJuYW1lIjoiYWNjdCIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzk0LDExOV0sImVycm9yTWVzc2FnZSI6IkFjY291bnQgaXMgbm90IG9wdGVkIGluIHRvIHRoZSBhc3NldCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzU0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg3XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5OSwxMjJdLCJlcnJvck1lc3NhZ2UiOiJhY2NvdW50IG9wdGVkIGludG8gYXNzZXQiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9XSwicGNPZmZzZXRNZXRob2QiOiJub25lIn0sImNsZWFyIjp7InNvdXJjZUluZm8iOltdLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifX0sInNvdXJjZSI6eyJhcHByb3ZhbCI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVlYQndjbTkyWVd4ZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJR2x1ZEdOaWJHOWpheUF4TVRnMUlERUtJQ0FnSUdKNWRHVmpZbXh2WTJzZ1ltRnpaVE15S0ZkTlNFWTBSa3hLVGt0Wk1rSlFSa3MzV1ZCV05VbEVOazlhTjB4V1JFSXlRalkyV2xSWVJVRk5URXd5VGxnMFYwcGFVa0VwSURCNE1UVXhaamRqTnpVS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlZmWVdOamIzVnVkRjloYzNObGRDOWpiMjUwY21GamRDNXdlVG94TUFvZ0lDQWdMeThnWTJ4aGMzTWdVbVZtWlhKbGJtTmxRV05qYjNWdWRFRnpjMlYwS0VGU1F6UkRiMjUwY21GamRDazZDaUFnSUNCMGVHNGdUblZ0UVhCd1FYSm5jd29nSUNBZ1lub2diV0ZwYmw5ZlgyRnNaMjl3ZVY5a1pXWmhkV3gwWDJOeVpXRjBaVUE1Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZUdFMk5XVTNZamsySURCNE1HSTJZMlpsTldRZ0x5OGdiV1YwYUc5a0lDSm5aWFJmWVhOelpYUmZZbUZzWVc1alpTZ3BkV2x1ZERZMElpd2diV1YwYUc5a0lDSm5aWFJmWVhOelpYUmZZbUZzWVc1alpWOTNhWFJvWDJGeVp5aGhaR1J5WlhOekxIVnBiblEyTkNsMWFXNTBOalFpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCblpYUmZZWE56WlhSZlltRnNZVzVqWlNCblpYUmZZWE56WlhSZlltRnNZVzVqWlY5M2FYUm9YMkZ5WndvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFEazZDaUFnSUNCMGVHNGdUMjVEYjIxd2JHVjBhVzl1Q2lBZ0lDQWhDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ0ppWUtJQ0FnSUhKbGRIVnliaUF2THlCdmJpQmxjbkp2Y2pvZ1QyNURiMjF3YkdWMGFXOXVJRzExYzNRZ1ltVWdUbTlQY0NBbUppQmpZVzRnYjI1c2VTQmpZV3hzSUhkb1pXNGdZM0psWVhScGJtY0tDZ292THlCemJXRnlkRjlqYjI1MGNtRmpkSE11Y21WbVpYSmxibU5sWDJGalkyOTFiblJmWVhOelpYUXVZMjl1ZEhKaFkzUXVVbVZtWlhKbGJtTmxRV05qYjNWdWRFRnpjMlYwTG1kbGRGOWhjM05sZEY5aVlXeGhibU5sVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1oyVjBYMkZ6YzJWMFgySmhiR0Z1WTJVNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sWDJGalkyOTFiblJmWVhOelpYUXZZMjl1ZEhKaFkzUXVjSGs2TVRndE1qQUtJQ0FnSUM4dklHRmpZM1FnUFNCQlkyTnZkVzUwS0FvZ0lDQWdMeThnSUNBZ0lDSlhUVWhHTkVaTVNrNUxXVEpDVUVaTE4xbFFWalZKUkRaUFdqZE1Wa1JDTWtJMk5scFVXRVZCVFV4TU1rNVlORmRLV2xKS1JsWllOalpOSWdvZ0lDQWdMeThnS1NBZ0l5QlNaWEJzWVdObElIZHBkR2dnZVc5MWNpQmhZMk52ZFc1MElHRmtaSEpsYzNNS0lDQWdJR0o1ZEdWalh6QWdMeThnWVdSa2NpQlhUVWhHTkVaTVNrNUxXVEpDVUVaTE4xbFFWalZKUkRaUFdqZE1Wa1JDTWtJMk5scFVXRVZCVFV4TU1rNVlORmRLV2xKS1JsWllOalpOQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjbVZtWlhKbGJtTmxYMkZqWTI5MWJuUmZZWE56WlhRdlkyOXVkSEpoWTNRdWNIazZNakVLSUNBZ0lDOHZJR0Z6YzJWMElEMGdRWE56WlhRb01URTROU2tnSUNNZ1VtVndiR0ZqWlNCM2FYUm9JSGx2ZFhJZ1lYTnpaWFFnYVdRS0lDQWdJR2x1ZEdOZk1DQXZMeUF4TVRnMUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sWDJGalkyOTFiblJmWVhOelpYUXZZMjl1ZEhKaFkzUXVjSGs2TWpNS0lDQWdJQzh2SUdGemMyVnlkQ0JoWTJOMExtbHpYMjl3ZEdWa1gybHVLR0Z6YzJWMEtTd2dJa0ZqWTI5MWJuUWdhWE1nYm05MElHOXdkR1ZrSUdsdUlIUnZJSFJvWlNCaGMzTmxkQ0lLSUNBZ0lHRnpjMlYwWDJodmJHUnBibWRmWjJWMElFRnpjMlYwUW1Gc1lXNWpaUW9nSUNBZ1luVnllU0F4Q2lBZ0lDQmhjM05sY25RZ0x5OGdRV05qYjNWdWRDQnBjeUJ1YjNRZ2IzQjBaV1FnYVc0Z2RHOGdkR2hsSUdGemMyVjBDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObFgyRmpZMjkxYm5SZllYTnpaWFF2WTI5dWRISmhZM1F1Y0hrNk1UZ3RNakFLSUNBZ0lDOHZJR0ZqWTNRZ1BTQkJZMk52ZFc1MEtBb2dJQ0FnTHk4Z0lDQWdJQ0pYVFVoR05FWk1TazVMV1RKQ1VFWkxOMWxRVmpWSlJEWlBXamRNVmtSQ01rSTJObHBVV0VWQlRVeE1NazVZTkZkS1dsSktSbFpZTmpaTklnb2dJQ0FnTHk4Z0tTQWdJeUJTWlhCc1lXTmxJSGRwZEdnZ2VXOTFjaUJoWTJOdmRXNTBJR0ZrWkhKbGMzTUtJQ0FnSUdKNWRHVmpYekFnTHk4Z1lXUmtjaUJYVFVoR05FWk1TazVMV1RKQ1VFWkxOMWxRVmpWSlJEWlBXamRNVmtSQ01rSTJObHBVV0VWQlRVeE1NazVZTkZkS1dsSktSbFpZTmpaTkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y21WbVpYSmxibU5sWDJGalkyOTFiblJmWVhOelpYUXZZMjl1ZEhKaFkzUXVjSGs2TWpFS0lDQWdJQzh2SUdGemMyVjBJRDBnUVhOelpYUW9NVEU0TlNrZ0lDTWdVbVZ3YkdGalpTQjNhWFJvSUhsdmRYSWdZWE56WlhRZ2FXUUtJQ0FnSUdsdWRHTmZNQ0F2THlBeE1UZzFDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNtVm1aWEpsYm1ObFgyRmpZMjkxYm5SZllYTnpaWFF2WTI5dWRISmhZM1F1Y0hrNk1qVUtJQ0FnSUM4dklISmxkSFZ5YmlCaGMzTmxkQzVpWVd4aGJtTmxLR0ZqWTNRcENpQWdJQ0JoYzNObGRGOW9iMnhrYVc1blgyZGxkQ0JCYzNObGRFSmhiR0Z1WTJVS0lDQWdJR0Z6YzJWeWRDQXZMeUJoWTJOdmRXNTBJRzl3ZEdWa0lHbHVkRzhnWVhOelpYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5eVpXWmxjbVZ1WTJWZllXTmpiM1Z1ZEY5aGMzTmxkQzlqYjI1MGNtRmpkQzV3ZVRveE5nb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNU0F2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTV5WldabGNtVnVZMlZmWVdOamIzVnVkRjloYzNObGRDNWpiMjUwY21GamRDNVNaV1psY21WdVkyVkJZMk52ZFc1MFFYTnpaWFF1WjJWMFgyRnpjMlYwWDJKaGJHRnVZMlZmZDJsMGFGOWhjbWRiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwblpYUmZZWE56WlhSZlltRnNZVzVqWlY5M2FYUm9YMkZ5WnpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl5WldabGNtVnVZMlZmWVdOamIzVnVkRjloYzNObGRDOWpiMjUwY21GamRDNXdlVG96TkFvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWm1WeVpXNWpaVjloWTJOdmRXNTBYMkZ6YzJWMEwyTnZiblJ5WVdOMExuQjVPak0yQ2lBZ0lDQXZMeUJoYzNObGNuUWdZV05qZEM1cGMxOXZjSFJsWkY5cGJpaGhjM05sZENrc0lDSkJZMk52ZFc1MElHbHpJRzV2ZENCdmNIUmxaQ0JwYmlCMGJ5QjBhR1VnWVhOelpYUWlDaUFnSUNCa2RYQXlDaUFnSUNCaGMzTmxkRjlvYjJ4a2FXNW5YMmRsZENCQmMzTmxkRUpoYkdGdVkyVUtJQ0FnSUdKMWNua2dNUW9nSUNBZ1lYTnpaWEowSUM4dklFRmpZMjkxYm5RZ2FYTWdibTkwSUc5d2RHVmtJR2x1SUhSdklIUm9aU0JoYzNObGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNKbFptVnlaVzVqWlY5aFkyTnZkVzUwWDJGemMyVjBMMk52Ym5SeVlXTjBMbkI1T2pNM0xUTTRDaUFnSUNBdkx5QWpJRWRsZENCMGFHVWdZWE56WlhRZ1ltRnNZVzVqWlFvZ0lDQWdMeThnY21WMGRYSnVJR0Z6YzJWMExtSmhiR0Z1WTJVb1lXTmpkQ2tLSUNBZ0lHRnpjMlYwWDJodmJHUnBibWRmWjJWMElFRnpjMlYwUW1Gc1lXNWpaUW9nSUNBZ1lYTnpaWEowSUM4dklHRmpZMjkxYm5RZ2IzQjBaV1FnYVc1MGJ5QmhjM05sZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0psWm1WeVpXNWpaVjloWTJOdmRXNTBYMkZ6YzJWMEwyTnZiblJ5WVdOMExuQjVPak0wQ2lBZ0lDQXZMeUJBWVdKcGJXVjBhRzlrQ2lBZ0lDQnBkRzlpQ2lBZ0lDQmllWFJsWTE4eElDOHZJREI0TVRVeFpqZGpOelVLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQnBiblJqWHpFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSIsImNsZWFyIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WTJ4bFlYSmZjM1JoZEdWZmNISnZaM0poYlNncElDMCtJSFZwYm5RMk5Eb0tiV0ZwYmpvS0lDQWdJSEIxYzJocGJuUWdNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDb1FrQkpnSWdzdzVlRldscXNhQzhxdjRmWHFCK2RuNjZqRG9QdlpuY2dHTFhwdCtXVG1JRUZSOThkVEViUVFBZE1Sa1VSREVZUklJQ0JLWmVlNVlFQzJ6K1hUWWFBSTRDQUFrQUhBQXhHUlF4R0JRUVF5Z2ljQUJGQVVRb0luQUFSQllwVEZDd0kwTTJHZ0UyR2dJWFNuQUFSUUZFY0FCRUZpbE1VTEFqUXc9PSIsImNsZWFyIjoiQzRFQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
