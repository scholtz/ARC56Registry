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

namespace Arc56.Generated.algorandfoundation.TEALScript.NFTFactory_77dc5a18
{


    public class NFTFactoryProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public NFTFactoryProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="name"> </param>
        /// <param name="unitName"> </param>
        public async Task<ulong> CreateNft(string name, string unitName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 2, 76, 115 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var unitNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); unitNameAbi.From(unitName);

            var result = await base.CallApp(new List<object> { abiHandle, nameAbi, unitNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateNft_Transactions(string name, string unitName, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 210, 2, 76, 115 };
            var nameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); nameAbi.From(name);
            var unitNameAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); unitNameAbi.From(unitName);

            return await base.MakeTransactionList(new List<object> { abiHandle, nameAbi, unitNameAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        /// <param name="asset"> </param>
        /// <param name="receiver"> </param>
        public async Task TransferNft(ulong asset, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 226, 96, 175 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            var result = await base.CallApp(new List<object> { abiHandle, assetAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> TransferNft_Transactions(ulong asset, Algorand.Address receiver, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 199, 226, 96, 175 };
            var assetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); assetAbi.From(asset);
            var receiverAbi = new AVM.ClientGenerator.ABI.ARC4.Types.Address(); receiverAbi.From(receiver);

            return await base.MakeTransactionList(new List<object> { abiHandle, assetAbi, receiverAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///
        ///</summary>
        public async Task CreateApplication(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> CreateApplication_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 184, 68, 123, 54 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbNCw1Nl0sIm5hbWUiOiJORlRGYWN0b3J5IiwiZGVzYyI6IiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVORlQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibmFtZSIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoidW5pdE5hbWUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoidHJhbnNmZXJORlQiLCJkZXNjIjpudWxsLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYXNzZXQiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6ImFkZHJlc3MiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJyZWNlaXZlciIsImRlc2MiOm51bGwsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpudWxsLCJldmVudHMiOm51bGwsInJlY29tbWVuZGF0aW9ucyI6bnVsbH0seyJuYW1lIjoiY3JlYXRlQXBwbGljYXRpb24iLCJkZXNjIjpudWxsLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6bnVsbCwiZXZlbnRzIjpudWxsLCJyZWNvbW1lbmRhdGlvbnMiOm51bGx9XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjowLCJieXRlcyI6MH0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MSwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo0In0seyJwYyI6WzEsMiwzLDRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIsInNvdXJjZSI6ImV4YW1wbGVzL2l0eG5zL2l0eG5zLmFsZ28udHM6NCJ9LHsicGMiOls1LDZdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0LCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjQifSx7InBjIjpbN10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTUsInNvdXJjZSI6ImV4YW1wbGVzL2l0eG5zL2l0eG5zLmFsZ28udHM6NCJ9LHsicGMiOls4LDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE2LCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjQifSx7InBjIjpbMTBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE3LCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjQifSx7InBjIjpbMTEsMTJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE4LCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjQifSx7InBjIjpbMTNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE5LCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjQifSx7InBjIjpbMTQsMTUsMTYsMTcsMTgsMTksMjAsMjEsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMjksMzAsMzEsMzIsMzMsMzQsMzUsMzYsMzcsMzgsMzldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjIwLCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjQifSx7InBjIjpbNDBdLCJlcnJvck1lc3NhZ2UiOiJUaGUgcmVxdWVzdGVkIGFjdGlvbiBpcyBub3QgaW1wbGVtZW50ZWQgaW4gdGhpcyBjb250cmFjdC4gQXJlIHlvdSB1c2luZyB0aGUgY29ycmVjdCBPbkNvbXBsZXRlPyBEaWQgeW91IHNldCB5b3VyIGFwcCBJRD8iLCJ0ZWFsIjoyNCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo0In0seyJwYyI6WzQxLDQyLDQzLDQ0LDQ1LDQ2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoyOSwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo1In0seyJwYyI6WzQ3LDQ4LDQ5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMiwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo1In0seyJwYyI6WzUwLDUxLDUyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozMywic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo1In0seyJwYyI6WzUzLDU0LDU1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNiwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo1In0seyJwYyI6WzU2LDU3LDU4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjozNywic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo1In0seyJwYyI6WzU5LDYwLDYxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo1In0seyJwYyI6WzYyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0MSwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo1In0seyJwYyI6WzYzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Miwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo1In0seyJwYyI6WzY0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0Mywic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo1In0seyJwYyI6WzY1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0NCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo1In0seyJwYyI6WzY2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0NSwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo1In0seyJwYyI6WzY3LDY4LDY5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo0OSwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo1In0seyJwYyI6WzcwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1Nywic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo2In0seyJwYyI6WzcxLDcyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo2In0seyJwYyI6WzczLDc0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo1OSwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo2In0seyJwYyI6Wzc1LDc2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2Mywic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo3In0seyJwYyI6Wzc3LDc4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2NCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo3In0seyJwYyI6Wzc5LDgwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo4In0seyJwYyI6WzgxLDgyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo2OSwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo4In0seyJwYyI6WzgzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Mywic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo5In0seyJwYyI6Wzg0LDg1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3NCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo5In0seyJwYyI6Wzg2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3Nywic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo2In0seyJwYyI6Wzg3LDg4XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo3OCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo2In0seyJwYyI6Wzg5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4MSwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo2In0seyJwYyI6WzkwLDkxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Miwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo2In0seyJwYyI6WzkyXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4Mywic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo1In0seyJwYyI6WzkzLDk0LDk1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo4OCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czoxMyJ9LHsicGMiOls5Nl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6ODksInNvdXJjZSI6ImV4YW1wbGVzL2l0eG5zL2l0eG5zLmFsZ28udHM6MTMifSx7InBjIjpbOTddLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkwLCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjEzIn0seyJwYyI6Wzk4LDk5XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5MSwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czoxMyJ9LHsicGMiOlsxMDBdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjkyLCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjEzIn0seyJwYyI6WzEwMV0sImVycm9yTWVzc2FnZSI6ImFyZ3VtZW50IDAgKHJlY2VpdmVyKSBmb3IgdHJhbnNmZXJORlQgbXVzdCBiZSBhIGFkZHJlc3MiLCJ0ZWFsIjo5NSwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czoxMyJ9LHsicGMiOlsxMDIsMTAzLDEwNF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6OTgsInNvdXJjZSI6ImV4YW1wbGVzL2l0eG5zL2l0eG5zLmFsZ28udHM6MTMifSx7InBjIjpbMTA1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjo5OSwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czoxMyJ9LHsicGMiOlsxMDYsMTA3LDEwOF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTAyLCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjEzIn0seyJwYyI6WzEwOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTAzLCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjEzIn0seyJwYyI6WzExMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTA0LCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjEzIn0seyJwYyI6WzExMSwxMTIsMTEzXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMDgsInNvdXJjZSI6ImV4YW1wbGVzL2l0eG5zL2l0eG5zLmFsZ28udHM6MTMifSx7InBjIjpbMTE0XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMTYsInNvdXJjZSI6ImV4YW1wbGVzL2l0eG5zL2l0eG5zLmFsZ28udHM6MTQifSx7InBjIjpbMTE1LDExNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTE3LCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjE0In0seyJwYyI6WzExNywxMThdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjExOCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czoxNCJ9LHsicGMiOlsxMTksMTIwXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMjIsInNvdXJjZSI6ImV4YW1wbGVzL2l0eG5zL2l0eG5zLmFsZ28udHM6MTUifSx7InBjIjpbMTIxLDEyMl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTIzLCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjE1In0seyJwYyI6WzEyM10sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTI3LCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjE2In0seyJwYyI6WzEyNCwxMjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEyOCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czoxNiJ9LHsicGMiOlsxMjYsMTI3XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxMzIsInNvdXJjZSI6ImV4YW1wbGVzL2l0eG5zL2l0eG5zLmFsZ28udHM6MTcifSx7InBjIjpbMTI4LDEyOV0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTMzLCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjE3In0seyJwYyI6WzEzMF0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTM2LCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjE0In0seyJwYyI6WzEzMSwxMzJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjEzNywic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czoxNCJ9LHsicGMiOlsxMzNdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0MCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czoxNCJ9LHsicGMiOlsxMzRdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0MSwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czoxMyJ9LHsicGMiOlsxMzVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0NCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo0In0seyJwYyI6WzEzNl0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTQ1LCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjQifSx7InBjIjpbMTM3LDEzOCwxMzksMTQwLDE0MSwxNDJdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE0OCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo0In0seyJwYyI6WzE0MywxNDQsMTQ1XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNDksInNvdXJjZSI6ImV4YW1wbGVzL2l0eG5zL2l0eG5zLmFsZ28udHM6NCJ9LHsicGMiOlsxNDYsMTQ3LDE0OCwxNDldLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1MCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo0In0seyJwYyI6WzE1MF0sImVycm9yTWVzc2FnZSI6InRoaXMgY29udHJhY3QgZG9lcyBub3QgaW1wbGVtZW50IHRoZSBnaXZlbiBBQkkgbWV0aG9kIGZvciBjcmVhdGUgTm9PcCIsInRlYWwiOjE1Mywic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo0In0seyJwYyI6WzE1MSwxNTIsMTUzLDE1NCwxNTUsMTU2XSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNTYsInNvdXJjZSI6ImV4YW1wbGVzL2l0eG5zL2l0eG5zLmFsZ28udHM6NCJ9LHsicGMiOlsxNTcsMTU4LDE1OSwxNjAsMTYxLDE2Ml0sImVycm9yTWVzc2FnZSI6bnVsbCwidGVhbCI6MTU3LCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjQifSx7InBjIjpbMTYzLDE2NCwxNjVdLCJlcnJvck1lc3NhZ2UiOm51bGwsInRlYWwiOjE1OCwic291cmNlIjoiZXhhbXBsZXMvaXR4bnMvaXR4bnMuYWxnby50czo0In0seyJwYyI6WzE2NiwxNjcsMTY4LDE2OSwxNzAsMTcxXSwiZXJyb3JNZXNzYWdlIjpudWxsLCJ0ZWFsIjoxNTksInNvdXJjZSI6ImV4YW1wbGVzL2l0eG5zL2l0eG5zLmFsZ28udHM6NCJ9LHsicGMiOlsxNzJdLCJlcnJvck1lc3NhZ2UiOiJ0aGlzIGNvbnRyYWN0IGRvZXMgbm90IGltcGxlbWVudCB0aGUgZ2l2ZW4gQUJJIG1ldGhvZCBmb3IgY2FsbCBOb09wIiwidGVhbCI6MTYyLCJzb3VyY2UiOiJleGFtcGxlcy9pdHhucy9pdHhucy5hbGdvLnRzOjQifV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDbWx1ZEdOaWJHOWpheUF4SURBS0NpOHZJRlJvYVhNZ1ZFVkJUQ0IzWVhNZ1oyVnVaWEpoZEdWa0lHSjVJRlJGUVV4VFkzSnBjSFFnZGpBdU1UQTNMaklLTHk4Z2FIUjBjSE02THk5bmFYUm9kV0l1WTI5dEwyRnNaMjl5WVc1a1ptOTFibVJoZEdsdmJpOVVSVUZNVTJOeWFYQjBDZ292THlCVWFHbHpJR052Ym5SeVlXTjBJR2x6SUdOdmJYQnNhV0Z1ZENCM2FYUm9JR0Z1WkM5dmNpQnBiWEJzWlcxbGJuUnpJSFJvWlNCbWIyeHNiM2RwYm1jZ1FWSkRjem9nV3lCQlVrTTBJRjBLQ2k4dklGUm9aU0JtYjJ4c2IzZHBibWNnZEdWdUlHeHBibVZ6SUc5bUlGUkZRVXdnYUdGdVpHeGxJR2x1YVhScFlXd2djSEp2WjNKaGJTQm1iRzkzQ2k4dklGUm9hWE1nY0dGMGRHVnliaUJwY3lCMWMyVmtJSFJ2SUcxaGEyVWdhWFFnWldGemVTQm1iM0lnWVc1NWIyNWxJSFJ2SUhCaGNuTmxJSFJvWlNCemRHRnlkQ0J2WmlCMGFHVWdjSEp2WjNKaGJTQmhibVFnWkdWMFpYSnRhVzVsSUdsbUlHRWdjM0JsWTJsbWFXTWdZV04wYVc5dUlHbHpJR0ZzYkc5M1pXUUtMeThnU0dWeVpTd2dZV04wYVc5dUlISmxabVZ5Y3lCMGJ5QjBhR1VnVDI1RGIyMXdiR1YwWlNCcGJpQmpiMjFpYVc1aGRHbHZiaUIzYVhSb0lIZG9aWFJvWlhJZ2RHaGxJR0Z3Y0NCcGN5QmlaV2x1WnlCamNtVmhkR1ZrSUc5eUlHTmhiR3hsWkFvdkx5QkZkbVZ5ZVNCd2IzTnphV0pzWlNCaFkzUnBiMjRnWm05eUlIUm9hWE1nWTI5dWRISmhZM1FnYVhNZ2NtVndjbVZ6Wlc1MFpXUWdhVzRnZEdobElITjNhWFJqYUNCemRHRjBaVzFsYm5RS0x5OGdTV1lnZEdobElHRmpkR2x2YmlCcGN5QnViM1FnYVcxd2JHVnRaVzUwWldRZ2FXNGdkR2hsSUdOdmJuUnlZV04wTENCcGRITWdjbVZ6Y0dWamRHbDJaU0JpY21GdVkyZ2dkMmxzYkNCaVpTQWlLazVQVkY5SlRWQk1SVTFGVGxSRlJDSWdkMmhwWTJnZ2FuVnpkQ0JqYjI1MFlXbHVjeUFpWlhKeUlncDBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2hDbkIxYzJocGJuUWdOZ29xQ25SNGJpQlBia052YlhCc1pYUnBiMjRLS3dwemQybDBZMmdnS21OaGJHeGZUbTlQY0NBcVRrOVVYMGxOVUV4RlRVVk9WRVZFSUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLbU55WldGMFpWOU9iMDl3SUNwT1QxUmZTVTFRVEVWTlJVNVVSVVFnS2s1UFZGOUpUVkJNUlUxRlRsUkZSQ0FxVGs5VVgwbE5VRXhGVFVWT1ZFVkVJQ3BPVDFSZlNVMVFURVZOUlU1VVJVUWdLazVQVkY5SlRWQk1SVTFGVGxSRlJBb0tLazVQVkY5SlRWQk1SVTFGVGxSRlJEb0tDUzh2SUZSb1pTQnlaWEYxWlhOMFpXUWdZV04wYVc5dUlHbHpJRzV2ZENCcGJYQnNaVzFsYm5SbFpDQnBiaUIwYUdseklHTnZiblJ5WVdOMExpQkJjbVVnZVc5MUlIVnphVzVuSUhSb1pTQmpiM0p5WldOMElFOXVRMjl0Y0d4bGRHVS9JRVJwWkNCNWIzVWdjMlYwSUhsdmRYSWdZWEJ3SUVsRVB3b0paWEp5Q2dvdkx5QmpjbVZoZEdWT1JsUW9jM1J5YVc1bkxITjBjbWx1WnlsMWFXNTBOalFLS21GaWFWOXliM1YwWlY5amNtVmhkR1ZPUmxRNkNna3ZMeUJVYUdVZ1FVSkpJSEpsZEhWeWJpQndjbVZtYVhnS0NYQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFDZ29KTHk4Z2RXNXBkRTVoYldVNklITjBjbWx1WndvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29KWlhoMGNtRmpkQ0F5SURBS0Nna3ZMeUJ1WVcxbE9pQnpkSEpwYm1jS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREVLQ1dWNGRISmhZM1FnTWlBd0Nnb0pMeThnWlhobFkzVjBaU0JqY21WaGRHVk9SbFFvYzNSeWFXNW5MSE4wY21sdVp5bDFhVzUwTmpRS0NXTmhiR3h6ZFdJZ1kzSmxZWFJsVGtaVUNnbHBkRzlpQ2dsamIyNWpZWFFLQ1d4dlp3b0phVzUwWXlBd0lDOHZJREVLQ1hKbGRIVnliZ29LTHk4Z1kzSmxZWFJsVGtaVUtHNWhiV1U2SUhOMGNtbHVaeXdnZFc1cGRFNWhiV1U2SUhOMGNtbHVaeWs2SUVGemMyVjBTVVFLWTNKbFlYUmxUa1pVT2dvSmNISnZkRzhnTWlBeENnb0pMeThnWlhoaGJYQnNaWE12YVhSNGJuTXZhWFI0Ym5NdVlXeG5ieTUwY3pvMkNna3ZMeUJ5WlhSMWNtNGdjMlZ1WkVGemMyVjBRM0psWVhScGIyNG9ld29KTHk4Z0lDQWdJQ0FnWTI5dVptbG5RWE56WlhST1lXMWxPaUJ1WVcxbExBb0pMeThnSUNBZ0lDQWdZMjl1Wm1sblFYTnpaWFJWYm1sMFRtRnRaVG9nZFc1cGRFNWhiV1VzQ2drdkx5QWdJQ0FnSUNCamIyNW1hV2RCYzNObGRGUnZkR0ZzT2lBeExBb0pMeThnSUNBZ0lIMHBPd29KYVhSNGJsOWlaV2RwYmdvSmNIVnphR2x1ZENBeklDOHZJR0ZqWm1jS0NXbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtDZ2t2THlCbGVHRnRjR3hsY3k5cGRIaHVjeTlwZEhodWN5NWhiR2R2TG5Sek9qY0tDUzh2SUdOdmJtWnBaMEZ6YzJWMFRtRnRaVG9nYm1GdFpRb0pabkpoYldWZlpHbG5JQzB4SUM4dklHNWhiV1U2SUhOMGNtbHVad29KYVhSNGJsOW1hV1ZzWkNCRGIyNW1hV2RCYzNObGRFNWhiV1VLQ2drdkx5QmxlR0Z0Y0d4bGN5OXBkSGh1Y3k5cGRIaHVjeTVoYkdkdkxuUnpPamdLQ1M4dklHTnZibVpwWjBGemMyVjBWVzVwZEU1aGJXVTZJSFZ1YVhST1lXMWxDZ2xtY21GdFpWOWthV2NnTFRJZ0x5OGdkVzVwZEU1aGJXVTZJSE4wY21sdVp3b0phWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEZWdWFYUk9ZVzFsQ2dvSkx5OGdaWGhoYlhCc1pYTXZhWFI0Ym5NdmFYUjRibk11WVd4bmJ5NTBjem81Q2drdkx5QmpiMjVtYVdkQmMzTmxkRlJ2ZEdGc09pQXhDZ2xwYm5SaklEQWdMeThnTVFvSmFYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRlJ2ZEdGc0Nnb0pMeThnUm1WbElHWnBaV3hrSUc1dmRDQnpaWFFzSUdSbFptRjFiSFJwYm1jZ2RHOGdNQW9KYVc1MFl5QXhJQzh2SURBS0NXbDBlRzVmWm1sbGJHUWdSbVZsQ2dvSkx5OGdVM1ZpYldsMElHbHVibVZ5SUhSeVlXNXpZV04wYVc5dUNnbHBkSGh1WDNOMVltMXBkQW9KYVhSNGJpQkRjbVZoZEdWa1FYTnpaWFJKUkFvSmNtVjBjM1ZpQ2dvdkx5QjBjbUZ1YzJabGNrNUdWQ2gxYVc1ME5qUXNZV1JrY21WemN5bDJiMmxrQ2lwaFltbGZjbTkxZEdWZmRISmhibk5tWlhKT1JsUTZDZ2t2THlCeVpXTmxhWFpsY2pvZ1lXUmtjbVZ6Y3dvSmRIaHVZU0JCY0hCc2FXTmhkR2x2YmtGeVozTWdNZ29KWkhWd0NnbHNaVzRLQ1hCMWMyaHBiblFnTXpJS0NUMDlDZ29KTHk4Z1lYSm5kVzFsYm5RZ01DQW9jbVZqWldsMlpYSXBJR1p2Y2lCMGNtRnVjMlpsY2s1R1ZDQnRkWE4wSUdKbElHRWdZV1JrY21WemN3b0pZWE56WlhKMENnb0pMeThnWVhOelpYUTZJSFZwYm5RMk5Bb0pkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvSlluUnZhUW9LQ1M4dklHVjRaV04xZEdVZ2RISmhibk5tWlhKT1JsUW9kV2x1ZERZMExHRmtaSEpsYzNNcGRtOXBaQW9KWTJGc2JITjFZaUIwY21GdWMyWmxjazVHVkFvSmFXNTBZeUF3SUM4dklERUtDWEpsZEhWeWJnb0tMeThnZEhKaGJuTm1aWEpPUmxRb1lYTnpaWFE2SUVGemMyVjBTVVFzSUhKbFkyVnBkbVZ5T2lCQlpHUnlaWE56S1RvZ2RtOXBaQXAwY21GdWMyWmxjazVHVkRvS0NYQnliM1J2SURJZ01Bb0tDUzh2SUdWNFlXMXdiR1Z6TDJsMGVHNXpMMmwwZUc1ekxtRnNaMjh1ZEhNNk1UUUtDUzh2SUhObGJtUkJjM05sZEZSeVlXNXpabVZ5S0hzS0NTOHZJQ0FnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUhKbFkyVnBkbVZ5TEFvSkx5OGdJQ0FnSUNBZ1lYTnpaWFJCYlc5MWJuUTZJREVzQ2drdkx5QWdJQ0FnSUNCNFptVnlRWE56WlhRNklHRnpjMlYwTEFvSkx5OGdJQ0FnSUgwcENnbHBkSGh1WDJKbFoybHVDZ2x3ZFhOb2FXNTBJRFFnTHk4Z1lYaG1aWElLQ1dsMGVHNWZabWxsYkdRZ1ZIbHdaVVZ1ZFcwS0Nna3ZMeUJsZUdGdGNHeGxjeTlwZEhodWN5OXBkSGh1Y3k1aGJHZHZMblJ6T2pFMUNna3ZMeUJoYzNObGRGSmxZMlZwZG1WeU9pQnlaV05sYVhabGNnb0pabkpoYldWZlpHbG5JQzB5SUM4dklISmxZMlZwZG1WeU9pQkJaR1J5WlhOekNnbHBkSGh1WDJacFpXeGtJRUZ6YzJWMFVtVmpaV2wyWlhJS0Nna3ZMeUJsZUdGdGNHeGxjeTlwZEhodWN5OXBkSGh1Y3k1aGJHZHZMblJ6T2pFMkNna3ZMeUJoYzNObGRFRnRiM1Z1ZERvZ01Rb0phVzUwWXlBd0lDOHZJREVLQ1dsMGVHNWZabWxsYkdRZ1FYTnpaWFJCYlc5MWJuUUtDZ2t2THlCbGVHRnRjR3hsY3k5cGRIaHVjeTlwZEhodWN5NWhiR2R2TG5Sek9qRTNDZ2t2THlCNFptVnlRWE56WlhRNklHRnpjMlYwQ2dsbWNtRnRaVjlrYVdjZ0xURWdMeThnWVhOelpYUTZJRUZ6YzJWMFNVUUtDV2wwZUc1ZlptbGxiR1FnV0dabGNrRnpjMlYwQ2dvSkx5OGdSbVZsSUdacFpXeGtJRzV2ZENCelpYUXNJR1JsWm1GMWJIUnBibWNnZEc4Z01Bb0phVzUwWXlBeElDOHZJREFLQ1dsMGVHNWZabWxsYkdRZ1JtVmxDZ29KTHk4Z1UzVmliV2wwSUdsdWJtVnlJSFJ5WVc1ellXTjBhVzl1Q2dscGRIaHVYM04xWW0xcGRBb0pjbVYwYzNWaUNnb3FZV0pwWDNKdmRYUmxYMk55WldGMFpVRndjR3hwWTJGMGFXOXVPZ29KYVc1MFl5QXdJQzh2SURFS0NYSmxkSFZ5YmdvS0ttTnlaV0YwWlY5T2IwOXdPZ29KY0hWemFHSjVkR1Z6SURCNFlqZzBORGRpTXpZZ0x5OGdiV1YwYUc5a0lDSmpjbVZoZEdWQmNIQnNhV05oZEdsdmJpZ3BkbTlwWkNJS0NYUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLQ1cxaGRHTm9JQ3BoWW1sZmNtOTFkR1ZmWTNKbFlYUmxRWEJ3YkdsallYUnBiMjRLQ2drdkx5QjBhR2x6SUdOdmJuUnlZV04wSUdSdlpYTWdibTkwSUdsdGNHeGxiV1Z1ZENCMGFHVWdaMmwyWlc0Z1FVSkpJRzFsZEdodlpDQm1iM0lnWTNKbFlYUmxJRTV2VDNBS0NXVnljZ29LS21OaGJHeGZUbTlQY0RvS0NYQjFjMmhpZVhSbGN5QXdlR1F5TURJMFl6Y3pJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxUa1pVS0hOMGNtbHVaeXh6ZEhKcGJtY3BkV2x1ZERZMElnb0pjSFZ6YUdKNWRHVnpJREI0WXpkbE1qWXdZV1lnTHk4Z2JXVjBhRzlrSUNKMGNtRnVjMlpsY2s1R1ZDaDFhVzUwTmpRc1lXUmtjbVZ6Y3lsMmIybGtJZ29KZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb0piV0YwWTJnZ0ttRmlhVjl5YjNWMFpWOWpjbVZoZEdWT1JsUWdLbUZpYVY5eWIzVjBaVjkwY21GdWMyWmxjazVHVkFvS0NTOHZJSFJvYVhNZ1kyOXVkSEpoWTNRZ1pHOWxjeUJ1YjNRZ2FXMXdiR1Z0Wlc1MElIUm9aU0JuYVhabGJpQkJRa2tnYldWMGFHOWtJR1p2Y2lCallXeHNJRTV2VDNBS0NXVnljZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXcifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQVFBeEdCU0JCZ3N4R1FpTkRBQnZBQUFBQUFBQUFBQUFBQUJoQUFBQUFBQUFBQUFBQUFDQUJCVWZmSFUyR2dKWEFnQTJHZ0ZYQWdDSUFBVVdVTEFpUTRvQ0FiR0JBN0lRaS8reUpvditzaVVpc2lJanNnR3p0RHlKTmhvQ1NSV0JJQkpFTmhvQkY0Z0FBaUpEaWdJQXNZRUVzaENML3JJVUlySVNpLyt5RVNPeUFiT0pJa09BQkxoRWV6WTJHZ0NPQWYveEFJQUUwZ0pNYzRBRXgrSmdyellhQUk0Qy8zMy9zUUE9IiwiY2xlYXIiOiJDZz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6ImFsZ29kIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo0LCJtaW5vciI6NCwicGF0Y2giOjEsImNvbW1pdEhhc2giOiI3YjYwN2NlNCJ9fSwiZXZlbnRzIjpudWxsLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
