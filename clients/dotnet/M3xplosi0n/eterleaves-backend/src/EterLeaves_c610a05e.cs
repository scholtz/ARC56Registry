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

namespace Arc56.Generated.M3xplosi0n.eterleaves_backend.EterLeaves_c610a05e
{


    public class EterLeavesProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public EterLeavesProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        public class Events
        {
            public class EterLeafCreatedEvent
            {
                public static readonly byte[] Selector = new byte[4] { 34, 197, 82, 238 };
                public const string Signature = "EterLeafCreated(uint64)";
                public static bool Matches(byte[] log) { return log != null && log.Length >= 4 && log[0] == Selector[0] && log[1] == Selector[1] && log[2] == Selector[2] && log[3] == Selector[3]; }
                public ulong Field0 { get; set; }

                public static EterLeafCreatedEvent Decode(byte[] log)
                {
                    if (!Matches(log)) throw new Exception("Log does not match event selector");
                    var ret = new EterLeafCreatedEvent();
                    var eventData = log.Skip(4).ToArray();
                    var queue = new Queue<byte>(eventData);
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vField0 = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vField0.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueField0 = vField0.ToValue();
                    if (valueField0 is ulong vField0Value) { ret.Field0 = vField0Value; }
                    return ret;

                }

            }

        }

        ///<summary>
        ///Creates a new Eter Leaf NFT
        ///</summary>
        /// <param name="latOffset">Latitude with offset (real_value + 90) * 1000000 </param>
        /// <param name="longOffset">Longitude with offset (real_value + 180) * 1000000 </param>
        /// <param name="message">Message associated with the Eter Leaf </param>
        public async Task<ulong> CreateEterLeaf(ulong latOffset, ulong longOffset, string message, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 119, 221, 30 };
            var latOffsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); latOffsetAbi.From(latOffset);
            var longOffsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); longOffsetAbi.From(longOffset);
            var messageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); messageAbi.From(message);

            var result = await base.CallApp(new List<object> { abiHandle, latOffsetAbi, longOffsetAbi, messageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> CreateEterLeaf_Transactions(ulong latOffset, ulong longOffset, string message, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 186, 119, 221, 30 };
            var latOffsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); latOffsetAbi.From(latOffset);
            var longOffsetAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); longOffsetAbi.From(longOffset);
            var messageAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); messageAbi.From(message);

            return await base.MakeTransactionList(new List<object> { abiHandle, latOffsetAbi, longOffsetAbi, messageAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the total number of Eter Leaves created
        ///</summary>
        public async Task<ulong> GetTotalSpotsTest(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 59, 73, 195 };

            var result = await base.SimApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> GetTotalSpotsTest_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 35, 59, 73, 195 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiRXRlckxlYXZlcyIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVFdGVyTGVhZiIsImRlc2MiOiJDcmVhdGVzIGEgbmV3IEV0ZXIgTGVhZiBORlQiLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibGF0T2Zmc2V0IiwiZGVzYyI6IkxhdGl0dWRlIHdpdGggb2Zmc2V0IChyZWFsX3ZhbHVlICsgOTApICogMTAwMDAwMCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoibG9uZ09mZnNldCIsImRlc2MiOiJMb25naXR1ZGUgd2l0aCBvZmZzZXQgKHJlYWxfdmFsdWUgKyAxODApICogMTAwMDAwMCIsImRlZmF1bHRWYWx1ZSI6bnVsbH0seyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoibWVzc2FnZSIsImRlc2MiOiJNZXNzYWdlIGFzc29jaWF0ZWQgd2l0aCB0aGUgRXRlciBMZWFmIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InVpbnQ2NCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6IklEIG9mIHRoZSBjcmVhdGVkIGFzc2V0In0sImFjdGlvbnMiOnsiY3JlYXRlIjpbXSwiY2FsbCI6WyJOb09wIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W3sibmFtZSI6IkV0ZXJMZWFmQ3JlYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfV0sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoiZ2V0VG90YWxTcG90c1Rlc3QiLCJkZXNjIjoiR2V0IHRoZSB0b3RhbCBudW1iZXIgb2YgRXRlciBMZWF2ZXMgY3JlYXRlZCIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOnRydWUsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX1dLCJzdGF0ZSI6eyJzY2hlbWEiOnsiZ2xvYmFsIjp7ImludHMiOjEsImJ5dGVzIjowfSwibG9jYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9fSwia2V5cyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn19LCJtYXBzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImJveCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfX19LCJiYXJlQWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInNvdXJjZUluZm8iOnsiYXBwcm92YWwiOnsic291cmNlSW5mbyI6W3sicGMiOlsxNDFdLCJlcnJvck1lc3NhZ2UiOiJJbnZhbGlkIGNvb3JkaW5hdGVzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbNjIsNzldLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gaXMgbm90IE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTVdLCJlcnJvck1lc3NhZ2UiOiJjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2NSw4Ml0sImVycm9yTWVzc2FnZSI6ImNhbiBvbmx5IGNhbGwgd2hlbiBub3QgY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDUsMTQ5LDMyOF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIEdsb2JhbFN0YXRlIGV4aXN0cyIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0JwYm5SallteHZZMnNnTUNBeENpQWdJQ0JpZVhSbFkySnNiMk5ySUNKMGIzUmhiRk53YjNSeklpQXdlREUxTVdZM1l6YzFDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdZbTU2SUcxaGFXNWZZV1owWlhKZmFXWmZaV3h6WlVBeUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhSbGNteGxZWFpsY3k5bGRHVnliR1ZoZG1WekxtRnNaMjh1ZEhNNk5nb2dJQ0FnTHk4Z2RHOTBZV3hUY0c5MGN5QTlJRWRzYjJKaGJGTjBZWFJsUEhWcGJuUTJORDRvZXlCcGJtbDBhV0ZzVm1Gc2RXVTZJREFnZlNrN0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGIzUmhiRk53YjNSeklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkR1Z5YkdWaGRtVnpMMlYwWlhKc1pXRjJaWE11WVd4bmJ5NTBjem8wQ2lBZ0lDQXZMeUJsZUhCdmNuUWdZMnhoYzNNZ1JYUmxja3hsWVhabGN5QmxlSFJsYm1SeklFTnZiblJ5WVdOMElIc0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDJKaGNtVmZjbTkxZEdsdVowQTVDaUFnSUNCd2RYTm9ZbmwwWlhOeklEQjRZbUUzTjJSa01XVWdNSGd5TXpOaU5EbGpNeUF2THlCdFpYUm9iMlFnSW1OeVpXRjBaVVYwWlhKTVpXRm1LSFZwYm5RMk5DeDFhVzUwTmpRc2MzUnlhVzVuS1hWcGJuUTJOQ0lzSUcxbGRHaHZaQ0FpWjJWMFZHOTBZV3hUY0c5MGMxUmxjM1FvS1hWcGJuUTJOQ0lLSUNBZ0lIUjRibUVnUVhCd2JHbGpZWFJwYjI1QmNtZHpJREFLSUNBZ0lHMWhkR05vSUcxaGFXNWZZM0psWVhSbFJYUmxja3hsWVdaZmNtOTFkR1ZBTlNCdFlXbHVYMmRsZEZSdmRHRnNVM0J2ZEhOVVpYTjBYM0p2ZFhSbFFEWUtDbTFoYVc1ZllXWjBaWEpmYVdaZlpXeHpaVUF4TXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZEdWeWJHVmhkbVZ6TDJWMFpYSnNaV0YyWlhNdVlXeG5ieTUwY3pvMENpQWdJQ0F2THlCbGVIQnZjblFnWTJ4aGMzTWdSWFJsY2t4bFlYWmxjeUJsZUhSbGJtUnpJRU52Ym5SeVlXTjBJSHNLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZaMlYwVkc5MFlXeFRjRzkwYzFSbGMzUmZjbTkxZEdWQU5qb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRHVnliR1ZoZG1WekwyVjBaWEpzWldGMlpYTXVZV3huYnk1MGN6bzNNQW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2g3SUhKbFlXUnZibXg1T2lCMGNuVmxJSDBwQ2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUdseklHNXZkQ0JPYjA5d0NpQWdJQ0IwZUc0Z1FYQndiR2xqWVhScGIyNUpSQW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHTmhiR3h6ZFdJZ1oyVjBWRzkwWVd4VGNHOTBjMVJsYzNRS0lDQWdJR2wwYjJJS0lDQWdJR0o1ZEdWalh6RWdMeThnTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0NtMWhhVzVmWTNKbFlYUmxSWFJsY2t4bFlXWmZjbTkxZEdWQU5Ub0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRHVnliR1ZoZG1WekwyVjBaWEpzWldGMlpYTXVZV3huYnk1MGN6b3hOUW9nSUNBZ0x5OGdZM0psWVhSbFJYUmxja3hsWVdZb2JHRjBUMlptYzJWME9pQjFhVzUwTmpRc0lHeHZibWRQWm1aelpYUTZJSFZwYm5RMk5Dd2diV1Z6YzJGblpUb2djM1J5YVc1bktUb2dkV2x1ZERZMElIc0tJQ0FnSUhSNGJpQlBia052YlhCc1pYUnBiMjRLSUNBZ0lDRUtJQ0FnSUdGemMyVnlkQ0F2THlCUGJrTnZiWEJzWlhScGIyNGdhWE1nYm05MElFNXZUM0FLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JoYzNObGNuUWdMeThnWTJGdUlHOXViSGtnWTJGc2JDQjNhR1Z1SUc1dmRDQmpjbVZoZEdsdVp3b2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMFpYSnNaV0YyWlhNdlpYUmxjbXhsWVhabGN5NWhiR2R2TG5Sek9qUUtJQ0FnSUM4dklHVjRjRzl5ZENCamJHRnpjeUJGZEdWeVRHVmhkbVZ6SUdWNGRHVnVaSE1nUTI5dWRISmhZM1FnZXdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTVFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTXdvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkR1Z5YkdWaGRtVnpMMlYwWlhKc1pXRjJaWE11WVd4bmJ5NTBjem94TlFvZ0lDQWdMeThnWTNKbFlYUmxSWFJsY2t4bFlXWW9iR0YwVDJabWMyVjBPaUIxYVc1ME5qUXNJR3h2Ym1kUFptWnpaWFE2SUhWcGJuUTJOQ3dnYldWemMyRm5aVG9nYzNSeWFXNW5LVG9nZFdsdWREWTBJSHNLSUNBZ0lHTmhiR3h6ZFdJZ1kzSmxZWFJsUlhSbGNreGxZV1lLSUNBZ0lHbDBiMklLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdNSGd4TlRGbU4yTTNOUW9nSUNBZ2MzZGhjQW9nSUNBZ1kyOXVZMkYwQ2lBZ0lDQnNiMmNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNCeVpYUjFjbTRLQ20xaGFXNWZZbUZ5WlY5eWIzVjBhVzVuUURrNkNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhSbGNteGxZWFpsY3k5bGRHVnliR1ZoZG1WekxtRnNaMjh1ZEhNNk5Bb2dJQ0FnTHk4Z1pYaHdiM0owSUdOc1lYTnpJRVYwWlhKTVpXRjJaWE1nWlhoMFpXNWtjeUJEYjI1MGNtRmpkQ0I3Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFERXpDaUFnSUNCMGVHNGdRWEJ3YkdsallYUnBiMjVKUkFvZ0lDQWdJUW9nSUNBZ1lYTnpaWEowSUM4dklHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQmpjbVZoZEdsdVp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZEdWeWJHVmhkbVZ6TDJWMFpYSnNaV0YyWlhNdVlXeG5ieTUwY3pvNlJYUmxja3hsWVhabGN5NWpjbVZoZEdWRmRHVnlUR1ZoWmloc1lYUlBabVp6WlhRNklIVnBiblEyTkN3Z2JHOXVaMDltWm5ObGREb2dkV2x1ZERZMExDQnRaWE56WVdkbE9pQmllWFJsY3lrZ0xUNGdkV2x1ZERZME9ncGpjbVZoZEdWRmRHVnlUR1ZoWmpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZEdWeWJHVmhkbVZ6TDJWMFpYSnNaV0YyWlhNdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z1kzSmxZWFJsUlhSbGNreGxZV1lvYkdGMFQyWm1jMlYwT2lCMWFXNTBOalFzSUd4dmJtZFBabVp6WlhRNklIVnBiblEyTkN3Z2JXVnpjMkZuWlRvZ2MzUnlhVzVuS1RvZ2RXbHVkRFkwSUhzS0lDQWdJSEJ5YjNSdklETWdNUW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjBaWEpzWldGMlpYTXZkWFJwYkhNdVlXeG5ieTUwY3pveE5Rb2dJQ0FnTHk4Z1kyOXVjM1FnYkdGMFZtRnNhV1FnUFNCc1lYUlBabVp6WlhRZ1BEMGdUVUZZWDB4QlZGOVdRVXhWUlRzS0lDQWdJR1p5WVcxbFgyUnBaeUF0TXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYwWlhKc1pXRjJaWE12ZFhScGJITXVZV3huYnk1MGN6bzBDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyOXVjM1FnVFVGWVgweEJWRjlXUVV4VlJUb2dkV2x1ZERZMElEMGdNVGd3TURBd01EQXdPeUF2THlBNU1DQXFJREV3TURBd01EQWdLaUF5Q2lBZ0lDQndkWE5vYVc1MElERTRNREF3TURBd01DQXZMeUF4T0RBd01EQXdNREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkR1Z5YkdWaGRtVnpMM1YwYVd4ekxtRnNaMjh1ZEhNNk1UVUtJQ0FnSUM4dklHTnZibk4wSUd4aGRGWmhiR2xrSUQwZ2JHRjBUMlptYzJWMElEdzlJRTFCV0Y5TVFWUmZWa0ZNVlVVN0NpQWdJQ0E4UFFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYwWlhKc1pXRjJaWE12ZFhScGJITXVZV3huYnk1MGN6b3hPQW9nSUNBZ0x5OGdZMjl1YzNRZ2JHOXVaMVpoYkdsa0lEMGdiRzl1WjA5bVpuTmxkQ0E4UFNCTlFWaGZURTlPUjE5V1FVeFZSVHNLSUNBZ0lHWnlZVzFsWDJScFp5QXRNZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjBaWEpzWldGMlpYTXZkWFJwYkhNdVlXeG5ieTUwY3pvMUNpQWdJQ0F2THlCbGVIQnZjblFnWTI5dWMzUWdUVUZZWDB4UFRrZGZWa0ZNVlVVNklIVnBiblEyTkNBOUlETTJNREF3TURBd01Ec2dMeThnTVRnd0lDb2dNVEF3TURBd01DQXFJRElLSUNBZ0lIQjFjMmhwYm5RZ016WXdNREF3TURBd0lDOHZJRE0yTURBd01EQXdNQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjBaWEpzWldGMlpYTXZkWFJwYkhNdVlXeG5ieTUwY3pveE9Bb2dJQ0FnTHk4Z1kyOXVjM1FnYkc5dVoxWmhiR2xrSUQwZ2JHOXVaMDltWm5ObGRDQThQU0JOUVZoZlRFOU9SMTlXUVV4VlJUc0tJQ0FnSUR3OUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhSbGNteGxZWFpsY3k5MWRHbHNjeTVoYkdkdkxuUnpPakl4Q2lBZ0lDQXZMeUJ5WlhSMWNtNGdiR0YwVm1Gc2FXUWdKaVlnYkc5dVoxWmhiR2xrSUQ4Z01TQTZJREE3Q2lBZ0lDQW1KZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjBaWEpzWldGMlpYTXZaWFJsY214bFlYWmxjeTVoYkdkdkxuUnpPakU0Q2lBZ0lDQXZMeUJoYzNObGNuUW9hWE5XWVd4cFpDQTlQVDBnTVN3Z0lrbHVkbUZzYVdRZ1kyOXZjbVJwYm1GMFpYTWlLVHNLSUNBZ0lHbHVkR05mTVNBdkx5QXhDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUVsdWRtRnNhV1FnWTI5dmNtUnBibUYwWlhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZEdWeWJHVmhkbVZ6TDJWMFpYSnNaV0YyWlhNdVlXeG5ieTUwY3pvMkNpQWdJQ0F2THlCMGIzUmhiRk53YjNSeklEMGdSMnh2WW1Gc1UzUmhkR1U4ZFdsdWREWTBQaWg3SUdsdWFYUnBZV3hXWVd4MVpUb2dNQ0I5S1RzS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmllWFJsWTE4d0lDOHZJQ0owYjNSaGJGTndiM1J6SWdvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjBiM1JoYkZOd2IzUnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QkhiRzlpWVd4VGRHRjBaU0JsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRHVnliR1ZoZG1WekwyVjBaWEpzWldGMlpYTXVZV3huYnk1MGN6b3lNZ29nSUNBZ0x5OGdkR2hwY3k1MGIzUmhiRk53YjNSekxuWmhiSFZsSUNzOUlERTdDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYwWlhKc1pXRjJaWE12WlhSbGNteGxZWFpsY3k1aGJHZHZMblJ6T2pZS0lDQWdJQzh2SUhSdmRHRnNVM0J2ZEhNZ1BTQkhiRzlpWVd4VGRHRjBaVHgxYVc1ME5qUStLSHNnYVc1cGRHbGhiRlpoYkhWbE9pQXdJSDBwT3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZEc5MFlXeFRjRzkwY3lJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZEdWeWJHVmhkbVZ6TDJWMFpYSnNaV0YyWlhNdVlXeG5ieTUwY3pveU1nb2dJQ0FnTHk4Z2RHaHBjeTUwYjNSaGJGTndiM1J6TG5aaGJIVmxJQ3M5SURFN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMFpYSnNaV0YyWlhNdlpYUmxjbXhsWVhabGN5NWhiR2R2TG5Sek9qVXhDaUFnSUNBdkx5QmpiMjV6ZENCc1lYUkNlWFJsY3lBOUlHOXdMbWwwYjJJb2JHRjBUMlptYzJWMEtUc0tJQ0FnSUdaeVlXMWxYMlJwWnlBdE13b2dJQ0FnYVhSdllnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMFpYSnNaV0YyWlhNdlpYUmxjbXhsWVhabGN5NWhiR2R2TG5Sek9qVXlDaUFnSUNBdkx5QmpiMjV6ZENCc2IyNW5RbmwwWlhNZ1BTQnZjQzVwZEc5aUtHeHZibWRQWm1aelpYUXBPd29nSUNBZ1puSmhiV1ZmWkdsbklDMHlDaUFnSUNCcGRHOWlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdlpYUmxjbXhsWVhabGN5OWxkR1Z5YkdWaGRtVnpMbUZzWjI4dWRITTZOVFlLSUNBZ0lDOHZJR052Ym5OMElHeGhkRk4wY2lBOUlHOXdMbU52Ym1OaGRDaENlWFJsY3lnaWJHRjBPaUlwTENCc1lYUkNlWFJsY3lrN0NpQWdJQ0J3ZFhOb1lubDBaWE1nSW14aGREb2lDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJR052Ym1OaGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMFpYSnNaV0YyWlhNdlpYUmxjbXhsWVhabGN5NWhiR2R2TG5Sek9qVTNDaUFnSUNBdkx5QmpiMjV6ZENCc2IyNW5VM1J5SUQwZ2IzQXVZMjl1WTJGMEtFSjVkR1Z6S0NJc2JHOXVaem9pS1N3Z2JHOXVaMEo1ZEdWektUc0tJQ0FnSUhCMWMyaGllWFJsY3lBaUxHeHZibWM2SWdvZ0lDQWdkVzVqYjNabGNpQXlDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkR1Z5YkdWaGRtVnpMMlYwWlhKc1pXRjJaWE11WVd4bmJ5NTBjem8xT0FvZ0lDQWdMeThnWTI5dWMzUWdiWE5uVTNSeUlEMGdiM0F1WTI5dVkyRjBLRUo1ZEdWektDSXNiWE5uT2lJcExDQnRjMmRDZVhSbGN5azdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0lpeHRjMmM2SWdvZ0lDQWdabkpoYldWZlpHbG5JQzB4Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZEdWeWJHVmhkbVZ6TDJWMFpYSnNaV0YyWlhNdVlXeG5ieTUwY3pvMk1Rb2dJQ0FnTHk4Z2JHVjBJRzFsZEdGa1lYUmhJRDBnYjNBdVkyOXVZMkYwS0d4aGRGTjBjaXdnYkc5dVoxTjBjaWs3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRHVnliR1ZoZG1WekwyVjBaWEpzWldGMlpYTXVZV3huYnk1MGN6bzJNZ29nSUNBZ0x5OGdiV1YwWVdSaGRHRWdQU0J2Y0M1amIyNWpZWFFvYldWMFlXUmhkR0VzSUcxeloxTjBjaWs3Q2lBZ0lDQnpkMkZ3Q2lBZ0lDQmpiMjVqWVhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZEdWeWJHVmhkbVZ6TDJWMFpYSnNaV0YyWlhNdVlXeG5ieTUwY3pveU9Bb2dJQ0FnTHk4Z1kyOXVjM1FnYzNCdmRFbGtRbmwwWlhNZ1BTQnZjQzVwZEc5aUtITndiM1JKWkNrN0NpQWdJQ0J6ZDJGd0NpQWdJQ0JwZEc5aUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WlhSbGNteGxZWFpsY3k5bGRHVnliR1ZoZG1WekxtRnNaMjh1ZEhNNk1qa0tJQ0FnSUM4dklHTnZibk4wSUdGemMyVjBUbUZ0WlNBOUlHOXdMbU52Ym1OaGRDaENlWFJsY3lnaVJYUmxjaUJNWldGbUlDTWlLU3dnYzNCdmRFbGtRbmwwWlhNcE93b2dJQ0FnY0hWemFHSjVkR1Z6SUNKRmRHVnlJRXhsWVdZZ0l5SUtJQ0FnSUdScFp5QXhDaUFnSUNCamIyNWpZWFFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkR1Z5YkdWaGRtVnpMMlYwWlhKc1pXRjJaWE11WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnWTI5dWMzUWdkWEpzSUQwZ2IzQXVZMjl1WTJGMEtFSjVkR1Z6S0NKcGNHWnpPaTh2WlhSbGNsOXNaV0ZtWDIxbGRHRmtZWFJoWHlJcExDQnpjRzkwU1dSQ2VYUmxjeWs3Q2lBZ0lDQndkWE5vWW5sMFpYTWdJbWx3Wm5NNkx5OWxkR1Z5WDJ4bFlXWmZiV1YwWVdSaGRHRmZJZ29nSUNBZ2RXNWpiM1psY2lBeUNpQWdJQ0JqYjI1allYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRHVnliR1ZoZG1WekwyVjBaWEpzWldGMlpYTXVZV3huYnk1MGN6b3pOQW9nSUNBZ0x5OGdZMjl1YzNRZ1lYTnpaWFJKWkNBOUlHTnlaV0YwWlVGdVpGUnlZVzV6Wm1WeVRrWlVLRzFsZEdGa1lYUmhMQ0JoYzNObGRFNWhiV1VzSUhWdWFYUk9ZVzFsTENCMWNtd3NJRlI0Ymk1elpXNWtaWElwT3dvZ0lDQWdkSGh1SUZObGJtUmxjZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjBaWEpzWldGMlpYTXZkWFJwYkhNdVlXeG5ieTUwY3pvME1TMDFOQW9nSUNBZ0x5OGdZMjl1YzNRZ2FYUjRibEpsYzNWc2RDQTlJR2wwZUc0S0lDQWdJQzh2SUNBZ0xtRnpjMlYwUTI5dVptbG5LSHNLSUNBZ0lDOHZJQ0FnSUNCMGIzUmhiRG9nTVN3S0lDQWdJQzh2SUNBZ0lDQmtaV05wYldGc2N6b2dNQ3dLSUNBZ0lDOHZJQ0FnSUNCMWJtbDBUbUZ0WlRvZ2RXNXBkRTVoYldVc0NpQWdJQ0F2THlBZ0lDQWdZWE56WlhST1lXMWxPaUJoYzNObGRFNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ2RYSnNPaUIxY213c0NpQWdJQ0F2THlBZ0lDQWdibTkwWlRvZ2JXVjBZV1JoZEdFc0NpQWdJQ0F2THlBZ0lDQWdiV0Z1WVdkbGNqb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdjbVZ6WlhKMlpUb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdabkpsWlhwbE9pQkhiRzlpWVd3dVkzVnljbVZ1ZEVGd2NHeHBZMkYwYVc5dVFXUmtjbVZ6Y3l3S0lDQWdJQzh2SUNBZ0lDQmpiR0YzWW1GamF6b2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lIMHBDaUFnSUNBdkx5QWdJQzV6ZFdKdGFYUW9LVHNLSUNBZ0lHbDBlRzVmWW1WbmFXNEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRHVnliR1ZoZG1WekwzVjBhV3h6TG1Gc1oyOHVkSE02TkRrS0lDQWdJQzh2SUcxaGJtRm5aWEk2SUVkc2IySmhiQzVqZFhKeVpXNTBRWEJ3YkdsallYUnBiMjVCWkdSeVpYTnpMQW9nSUNBZ1oyeHZZbUZzSUVOMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkR1Z5YkdWaGRtVnpMM1YwYVd4ekxtRnNaMjh1ZEhNNk5UQXROVElLSUNBZ0lDOHZJSEpsYzJWeWRtVTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z1puSmxaWHBsT2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJR05zWVhkaVlXTnJPaUJIYkc5aVlXd3VZM1Z5Y21WdWRFRndjR3hwWTJGMGFXOXVRV1JrY21WemN5d0tJQ0FnSUdSMWNHNGdNd29nSUNBZ2FYUjRibDltYVdWc1pDQkRiMjVtYVdkQmMzTmxkRU5zWVhkaVlXTnJDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBSbkpsWlhwbENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFVtVnpaWEoyWlFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEUxaGJtRm5aWElLSUNBZ0lIVnVZMjkyWlhJZ013b2dJQ0FnYVhSNGJsOW1hV1ZzWkNCT2IzUmxDaUFnSUNCemQyRndDaUFnSUNCcGRIaHVYMlpwWld4a0lFTnZibVpwWjBGemMyVjBWVkpNQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRU52Ym1acFowRnpjMlYwVG1GdFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMFpYSnNaV0YyWlhNdlpYUmxjbXhsWVhabGN5NWhiR2R2TG5Sek9qTXdDaUFnSUNBdkx5QmpiMjV6ZENCMWJtbDBUbUZ0WlNBOUlFSjVkR1Z6S0NKRlRFVkJSaUlwT3dvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0pGVEVWQlJpSUtJQ0FnSUdsMGVHNWZabWxsYkdRZ1EyOXVabWxuUVhOelpYUlZibWwwVG1GdFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMFpYSnNaV0YyWlhNdmRYUnBiSE11WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnWkdWamFXMWhiSE02SURBc0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JEYjI1bWFXZEJjM05sZEVSbFkybHRZV3h6Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFJsY214bFlYWmxjeTkxZEdsc2N5NWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QjBiM1JoYkRvZ01Td0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0JwZEhodVgyWnBaV3hrSUVOdmJtWnBaMEZ6YzJWMFZHOTBZV3dLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWxkR1Z5YkdWaGRtVnpMM1YwYVd4ekxtRnNaMjh1ZEhNNk5ERXROVE1LSUNBZ0lDOHZJR052Ym5OMElHbDBlRzVTWlhOMWJIUWdQU0JwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEVOdmJtWnBaeWg3Q2lBZ0lDQXZMeUFnSUNBZ2RHOTBZV3c2SURFc0NpQWdJQ0F2THlBZ0lDQWdaR1ZqYVcxaGJITTZJREFzQ2lBZ0lDQXZMeUFnSUNBZ2RXNXBkRTVoYldVNklIVnVhWFJPWVcxbExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFRtRnRaVG9nWVhOelpYUk9ZVzFsTEFvZ0lDQWdMeThnSUNBZ0lIVnliRG9nZFhKc0xBb2dJQ0FnTHk4Z0lDQWdJRzV2ZEdVNklHMWxkR0ZrWVhSaExBb2dJQ0FnTHk4Z0lDQWdJRzFoYm1GblpYSTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJSEpsYzJWeWRtVTZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQWdJR1p5WldWNlpUb2dSMnh2WW1Gc0xtTjFjbkpsYm5SQmNIQnNhV05oZEdsdmJrRmtaSEpsYzNNc0NpQWdJQ0F2THlBZ0lDQWdZMnhoZDJKaFkyczZJRWRzYjJKaGJDNWpkWEp5Wlc1MFFYQndiR2xqWVhScGIyNUJaR1J5WlhOekxBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2NIVnphR2x1ZENBeklDOHZJRE1LSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMFpYSnNaV0YyWlhNdmRYUnBiSE11WVd4bmJ5NTBjem8wTVMwMU5Bb2dJQ0FnTHk4Z1kyOXVjM1FnYVhSNGJsSmxjM1ZzZENBOUlHbDBlRzRLSUNBZ0lDOHZJQ0FnTG1GemMyVjBRMjl1Wm1sbktIc0tJQ0FnSUM4dklDQWdJQ0IwYjNSaGJEb2dNU3dLSUNBZ0lDOHZJQ0FnSUNCa1pXTnBiV0ZzY3pvZ01Dd0tJQ0FnSUM4dklDQWdJQ0IxYm1sMFRtRnRaVG9nZFc1cGRFNWhiV1VzQ2lBZ0lDQXZMeUFnSUNBZ1lYTnpaWFJPWVcxbE9pQmhjM05sZEU1aGJXVXNDaUFnSUNBdkx5QWdJQ0FnZFhKc09pQjFjbXdzQ2lBZ0lDQXZMeUFnSUNBZ2JtOTBaVG9nYldWMFlXUmhkR0VzQ2lBZ0lDQXZMeUFnSUNBZ2JXRnVZV2RsY2pvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ2NtVnpaWEoyWlRvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUNBZ1puSmxaWHBsT2lCSGJHOWlZV3d1WTNWeWNtVnVkRUZ3Y0d4cFkyRjBhVzl1UVdSa2NtVnpjeXdLSUNBZ0lDOHZJQ0FnSUNCamJHRjNZbUZqYXpvZ1IyeHZZbUZzTG1OMWNuSmxiblJCY0hCc2FXTmhkR2x2YmtGa1pISmxjM01zQ2lBZ0lDQXZMeUFnSUgwcENpQWdJQ0F2THlBZ0lDNXpkV0p0YVhRb0tUc0tJQ0FnSUdsMGVHNWZjM1ZpYldsMENpQWdJQ0JwZEhodUlFTnlaV0YwWldSQmMzTmxkRWxFQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFJsY214bFlYWmxjeTkxZEdsc2N5NWhiR2R2TG5Sek9qVTVMVFkxQ2lBZ0lDQXZMeUJwZEhodUNpQWdJQ0F2THlBZ0lDNWhjM05sZEZSeVlXNXpabVZ5S0hzS0lDQWdJQzh2SUNBZ0lDQjRabVZ5UVhOelpYUTZJR0Z6YzJWMFNXUXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUkJiVzkxYm5RNklERXNDaUFnSUNBdkx5QWdJQ0FnWVhOelpYUlNaV05sYVhabGNqb2djbVZqWldsMlpYSXNDaUFnSUNBdkx5QWdJSDBwQ2lBZ0lDQXZMeUFnSUM1emRXSnRhWFFvS1RzS0lDQWdJR2wwZUc1ZlltVm5hVzRLSUNBZ0lITjNZWEFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdRWE56WlhSU1pXTmxhWFpsY2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMlYwWlhKc1pXRjJaWE12ZFhScGJITXVZV3huYnk1MGN6bzJNZ29nSUNBZ0x5OGdZWE56WlhSQmJXOTFiblE2SURFc0NpQWdJQ0JwYm5Salh6RWdMeThnTVFvZ0lDQWdhWFI0Ymw5bWFXVnNaQ0JCYzNObGRFRnRiM1Z1ZEFvZ0lDQWdaSFZ3Q2lBZ0lDQnBkSGh1WDJacFpXeGtJRmhtWlhKQmMzTmxkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjBaWEpzWldGMlpYTXZkWFJwYkhNdVlXeG5ieTUwY3pvMU9TMDJOQW9nSUNBZ0x5OGdhWFI0YmdvZ0lDQWdMeThnSUNBdVlYTnpaWFJVY21GdWMyWmxjaWg3Q2lBZ0lDQXZMeUFnSUNBZ2VHWmxja0Z6YzJWME9pQmhjM05sZEVsa0xBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFFXMXZkVzUwT2lBeExBb2dJQ0FnTHk4Z0lDQWdJR0Z6YzJWMFVtVmpaV2wyWlhJNklISmxZMlZwZG1WeUxBb2dJQ0FnTHk4Z0lDQjlLUW9nSUNBZ2NIVnphR2x1ZENBMElDOHZJRFFLSUNBZ0lHbDBlRzVmWm1sbGJHUWdWSGx3WlVWdWRXMEtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JwZEhodVgyWnBaV3hrSUVabFpRb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMFpYSnNaV0YyWlhNdmRYUnBiSE11WVd4bmJ5NTBjem8xT1MwMk5Rb2dJQ0FnTHk4Z2FYUjRiZ29nSUNBZ0x5OGdJQ0F1WVhOelpYUlVjbUZ1YzJabGNpaDdDaUFnSUNBdkx5QWdJQ0FnZUdabGNrRnpjMlYwT2lCaGMzTmxkRWxrTEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwUVcxdmRXNTBPaUF4TEFvZ0lDQWdMeThnSUNBZ0lHRnpjMlYwVW1WalpXbDJaWEk2SUhKbFkyVnBkbVZ5TEFvZ0lDQWdMeThnSUNCOUtRb2dJQ0FnTHk4Z0lDQXVjM1ZpYldsMEtDazdDaUFnSUNCcGRIaHVYM04xWW0xcGRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJWMFpYSnNaV0YyWlhNdlpYUmxjbXhsWVhabGN5NWhiR2R2TG5Sek9qTTNDaUFnSUNBdkx5QmxiV2wwS0NKRmRHVnlUR1ZoWmtOeVpXRjBaV1FpTENCaGMzTmxkRWxrS1RzS0lDQWdJR1IxY0FvZ0lDQWdhWFJ2WWdvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TWpKak5UVXlaV1VnTHk4Z2JXVjBhRzlrSUNKRmRHVnlUR1ZoWmtOeVpXRjBaV1FvZFdsdWREWTBLU0lLSUNBZ0lITjNZWEFLSUNBZ0lHTnZibU5oZEFvZ0lDQWdiRzluQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZaWFJsY214bFlYWmxjeTlsZEdWeWJHVmhkbVZ6TG1Gc1oyOHVkSE02TXprS0lDQWdJQzh2SUhKbGRIVnliaUJoYzNObGRFbGtPd29nSUNBZ2NtVjBjM1ZpQ2dvS0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyVjBaWEpzWldGMlpYTXZaWFJsY214bFlYWmxjeTVoYkdkdkxuUnpPanBGZEdWeVRHVmhkbVZ6TG1kbGRGUnZkR0ZzVTNCdmRITlVaWE4wS0NrZ0xUNGdkV2x1ZERZME9ncG5aWFJVYjNSaGJGTndiM1J6VkdWemREb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5bGRHVnliR1ZoZG1WekwyVjBaWEpzWldGMlpYTXVZV3huYnk1MGN6bzJDaUFnSUNBdkx5QjBiM1JoYkZOd2IzUnpJRDBnUjJ4dlltRnNVM1JoZEdVOGRXbHVkRFkwUGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nTUNCOUtUc0tJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKMGIzUmhiRk53YjNSeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCSGJHOWlZV3hUZEdGMFpTQmxlR2x6ZEhNS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTlsZEdWeWJHVmhkbVZ6TDJWMFpYSnNaV0YyWlhNdVlXeG5ieTUwY3pvM01nb2dJQ0FnTHk4Z2NtVjBkWEp1SUhSb2FYTXVkRzkwWVd4VGNHOTBjeTUyWVd4MVpUc0tJQ0FnSUhKbGRITjFZZ289IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDaUFDQUFFbUFncDBiM1JoYkZOd2IzUnpCQlVmZkhVeEdFQUFBeWdpWnpFYlFRQkhnZ0lFdW5mZEhnUWpPMG5ETmhvQWpnSUFFd0FDSWtNeEdSUkVNUmhFaUFFQUZpbE1VTEFqUXpFWkZFUXhHRVEyR2dFWE5ob0NGellhQTFjQ0FJZ0FFaFlwVEZDd0kwTXhHVUQveVRFWUZFUWpRNG9EQVl2OWdZQ3E2bFVPaS82QmdOVFVxd0VPRUNNU1JDSW9aVVFpS0dWRUl3Z29UR2VML1JhTC9oYUFCR3hoZERwUEFsQ0FCaXhzYjI1bk9rOENVSUFGTEcxelp6cUwvMUJPQWxCTVVFd1dnQXRGZEdWeUlFeGxZV1lnSTBzQlVJQWFhWEJtY3pvdkwyVjBaWEpmYkdWaFpsOXRaWFJoWkdGMFlWOVBBbEF4QUxFeUNrY0RzaXl5SzdJcXNpbFBBN0lGVExJblRMSW1nQVZGVEVWQlJySWxJcklqSTdJaWdRT3lFQ0t5QWJPMFBMRk1zaFFqc2hKSnNoR0JCTElRSXJJQnMwa1dnQVFpeFZMdVRGQ3dpU0lvWlVTSiIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NCwibWlub3IiOjcsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W3sibmFtZSI6IkV0ZXJMZWFmQ3JlYXRlZCIsImRlc2MiOm51bGwsImFyZ3MiOlt7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiIwIiwiZGVzYyI6bnVsbH1dfV0sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
