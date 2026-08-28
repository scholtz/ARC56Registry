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

namespace Arc56.Generated.CorvidLabs.arcron.Pulse_f3b5c12d
{


    //
    // Demo upkeep target: a public heartbeat counter.
    //
    //    Designed to be driven by the Keeper contract. `tick` takes no arguments
    //    beyond its method selector, which is the only shape Arcron could call
    //    before #8; `tick_with` takes real arguments, which is the shape it can
    //    call now. Permissionless by design — it is a demo, not a gate.
    //    
    //
    public class PulseProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public PulseProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
        }

        ///<summary>
        ///
        ///</summary>
        public async Task<ulong> Tick(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 77, 95, 11 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> Tick_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 77, 77, 95, 11 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///A hook with arguments of its own; returns the new count.
        ///Unreachable through an upkeep before #8, because an ARC-4 method needs its selector and each argument in an app arg of its own and Arcron could only send one.
        ///</summary>
        /// <param name="beats"> </param>
        /// <param name="note"> </param>
        public async Task<ulong> TickWith(ulong beats, string note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 164, 130, 186 };
            var beatsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); beatsAbi.From(beats);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); noteAbi.From(note);

            var result = await base.CallApp(new List<object> { abiHandle, beatsAbi, noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> TickWith_Transactions(ulong beats, string note, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 78, 164, 130, 186 };
            var beatsAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); beatsAbi.From(beats);
            var noteAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); noteAbi.From(note);

            return await base.MakeTransactionList(new List<object> { abiHandle, beatsAbi, noteAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiUHVsc2UiLCJkZXNjIjoiRGVtbyB1cGtlZXAgdGFyZ2V0OiBhIHB1YmxpYyBoZWFydGJlYXQgY291bnRlci5cblxuICAgIERlc2lnbmVkIHRvIGJlIGRyaXZlbiBieSB0aGUgS2VlcGVyIGNvbnRyYWN0LiBgdGlja2AgdGFrZXMgbm8gYXJndW1lbnRzXG4gICAgYmV5b25kIGl0cyBtZXRob2Qgc2VsZWN0b3IsIHdoaWNoIGlzIHRoZSBvbmx5IHNoYXBlIEFyY3JvbiBjb3VsZCBjYWxsXG4gICAgYmVmb3JlICM4OyBgdGlja193aXRoYCB0YWtlcyByZWFsIGFyZ3VtZW50cywgd2hpY2ggaXMgdGhlIHNoYXBlIGl0IGNhblxuICAgIGNhbGwgbm93LiBQZXJtaXNzaW9ubGVzcyBieSBkZXNpZ24g4oCUIGl0IGlzIGEgZGVtbywgbm90IGEgZ2F0ZS5cbiAgICAiLCJuZXR3b3JrcyI6e30sInN0cnVjdHMiOnt9LCJNZXRob2RzIjpbeyJuYW1lIjoidGljayIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6InRpY2tfd2l0aCIsImRlc2MiOiJBIGhvb2sgd2l0aCBhcmd1bWVudHMgb2YgaXRzIG93bjsgcmV0dXJucyB0aGUgbmV3IGNvdW50LlxuVW5yZWFjaGFibGUgdGhyb3VnaCBhbiB1cGtlZXAgYmVmb3JlICM4LCBiZWNhdXNlIGFuIEFSQy00IG1ldGhvZCBuZWVkcyBpdHMgc2VsZWN0b3IgYW5kIGVhY2ggYXJndW1lbnQgaW4gYW4gYXBwIGFyZyBvZiBpdHMgb3duIGFuZCBBcmNyb24gY291bGQgb25seSBzZW5kIG9uZS4iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYmVhdHMiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9LHsidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6Im5vdGUiLCJkZXNjIjpudWxsLCJkZWZhdWx0VmFsdWUiOm51bGx9XSwicmV0dXJucyI6eyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjF9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6WyJOb09wIl0sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE1Nl0sImVycm9yTWVzc2FnZSI6IlRvbyBtYW55IGJlYXRzIGZvciBvbmUgdGljayIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEwNCwxMTcsMTYwLDE4MF0sImVycm9yTWVzc2FnZSI6ImNoZWNrIHNlbGYuYmVhdHMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQwXSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ4XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzEzM10sImVycm9yTWVzc2FnZSI6ImludmFsaWQgbnVtYmVyIG9mIGJ5dGVzIGZvciBhcmM0LnVpbnQ2NCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbUpsWVhSeklpQWliR0Z6ZEY5aVpXRjBYM0p2ZFc1a0lpQWliR0Z6ZEY5dWIzUmxJaUF3ZURFMU1XWTNZemMxQ2lBZ0lDQjBlRzRnUVhCd2JHbGpZWFJwYjI1SlJBb2dJQ0FnWW01NklHMWhhVzVmWVdaMFpYSmZhV1pmWld4elpVQXlDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmNIVnNjMlV2WTI5dWRISmhZM1F1Y0hrNk1qRUtJQ0FnSUM4dklITmxiR1l1WW1WaGRITWdQU0JIYkc5aVlXeFRkR0YwWlNoVlNXNTBOalFvTUNrcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaVpXRjBjeUlLSUNBZ0lHbHVkR05mTUNBdkx5QXdDaUFnSUNCaGNIQmZaMnh2WW1Gc1gzQjFkQW9nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzQjFiSE5sTDJOdmJuUnlZV04wTG5CNU9qSXlDaUFnSUNBdkx5QnpaV3htTG14aGMzUmZZbVZoZEY5eWIzVnVaQ0E5SUVkc2IySmhiRk4wWVhSbEtGVkpiblEyTkNnd0tTa0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0lteGhjM1JmWW1WaGRGOXliM1Z1WkNJS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IxYkhObEwyTnZiblJ5WVdOMExuQjVPakl6Q2lBZ0lDQXZMeUJ6Wld4bUxteGhjM1JmYm05MFpTQTlJRWRzYjJKaGJGTjBZWFJsS0ZOMGNtbHVaeWdpSWlrcENpQWdJQ0JpZVhSbFkxOHlJQzh2SUNKc1lYTjBYMjV2ZEdVaUNpQWdJQ0J3ZFhOb1lubDBaWE1nSWlJS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkV3h6WlM5amIyNTBjbUZqZEM1d2VUb3hNUW9nSUNBZ0x5OGdZMnhoYzNNZ1VIVnNjMlVvUVZKRE5FTnZiblJ5WVdOMEtUb0tJQ0FnSUhSNGJpQk9kVzFCY0hCQmNtZHpDaUFnSUNCaWVpQnRZV2x1WDE5ZllXeG5iM0I1WDJSbFptRjFiSFJmWTNKbFlYUmxRREV4Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNCaGMzTmxjblFLSUNBZ0lIQjFjMmhpZVhSbGMzTWdNSGcwWkRSa05XWXdZaUF3ZURSbFlUUTRNbUpoSUM4dklHMWxkR2h2WkNBaWRHbGpheWdwZFdsdWREWTBJaXdnYldWMGFHOWtJQ0owYVdOclgzZHBkR2dvZFdsdWREWTBMSE4wY21sdVp5bDFhVzUwTmpRaUNpQWdJQ0IwZUc1aElFRndjR3hwWTJGMGFXOXVRWEpuY3lBd0NpQWdJQ0J0WVhSamFDQjBhV05ySUhScFkydGZkMmwwYUFvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzQjVYMlJsWm1GMWJIUmZZM0psWVhSbFFERXhPZ29nSUNBZ2RIaHVJRTl1UTI5dGNHeGxkR2x2YmdvZ0lDQWdJUW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJQ0VLSUNBZ0lDWW1DaUFnSUNCeVpYUjFjbTRLQ2dvdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdWNIVnNjMlV1WTI5dWRISmhZM1F1VUhWc2MyVXVkR2xqYTF0eWIzVjBhVzVuWFNncElDMCtJSFp2YVdRNkNuUnBZMnM2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSFZzYzJVdlkyOXVkSEpoWTNRdWNIazZNamNLSUNBZ0lDOHZJSE5sYkdZdVltVmhkSE11ZG1Gc2RXVWdLejBnTVFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUpsWVhSeklnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5blpYUmZaWGdLSUNBZ0lHRnpjMlZ5ZENBdkx5QmphR1ZqYXlCelpXeG1MbUpsWVhSeklHVjRhWE4wY3dvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lDc0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltSmxZWFJ6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZFd4elpTOWpiMjUwY21GamRDNXdlVG95T0FvZ0lDQWdMeThnYzJWc1ppNXNZWE4wWDJKbFlYUmZjbTkxYm1RdWRtRnNkV1VnUFNCSGJHOWlZV3d1Y205MWJtUUtJQ0FnSUdKNWRHVmpYekVnTHk4Z0lteGhjM1JmWW1WaGRGOXliM1Z1WkNJS0lDQWdJR2RzYjJKaGJDQlNiM1Z1WkFvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTl3ZFd4elpTOWpiMjUwY21GamRDNXdlVG95T1FvZ0lDQWdMeThnY21WMGRYSnVJSE5sYkdZdVltVmhkSE11ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKaVpXRjBjeUlLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2djMlZzWmk1aVpXRjBjeUJsZUdsemRITUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RXeHpaUzlqYjI1MGNtRmpkQzV3ZVRveU5Rb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpDZ3BDaUFnSUNCcGRHOWlDaUFnSUNCaWVYUmxZMTh6SUM4dklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TG5CMWJITmxMbU52Ym5SeVlXTjBMbEIxYkhObExuUnBZMnRmZDJsMGFGdHliM1YwYVc1blhTZ3BJQzArSUhadmFXUTZDblJwWTJ0ZmQybDBhRG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OXdkV3h6WlM5amIyNTBjbUZqZEM1d2VUb3pNUW9nSUNBZ0x5OGdRR0ZpYVcxbGRHaHZaQ2dwQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF4Q2lBZ0lDQmtkWEFLSUNBZ0lHeGxiZ29nSUNBZ2NIVnphR2x1ZENBNENpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExuVnBiblEyTkFvZ0lDQWdZblJ2YVFvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTWdvZ0lDQWdaSFZ3Q2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1pYaDBjbUZqZEY5MWFXNTBNVFlnTHk4Z2IyNGdaWEp5YjNJNklHbHVkbUZzYVdRZ1lYSnlZWGtnYkdWdVozUm9JR2hsWVdSbGNnb2dJQ0FnY0hWemFHbHVkQ0F5Q2lBZ0lDQXJDaUFnSUNCa2FXY2dNUW9nSUNBZ2JHVnVDaUFnSUNBOVBRb2dJQ0FnWVhOelpYSjBJQzh2SUdsdWRtRnNhV1FnYm5WdFltVnlJRzltSUdKNWRHVnpJR1p2Y2lCaGNtTTBMbVI1Ym1GdGFXTmZZWEp5WVhrOFlYSmpOQzUxYVc1ME9ENEtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RXeHpaUzlqYjI1MGNtRmpkQzV3ZVRvek9TMDBOZ29nSUNBZ0x5OGdJeUJDYjNWdVpDQjBhR1VnYVc1amNtVnRaVzUwTGlCVmJtSnZkVzVrWldRc0lHOXVaU0JqWVd4c0lHTnZkV3hrSUhObGRDQjBhR1VnWTI5MWJuUmxjaUJ1WldGeUNpQWdJQ0F2THlBaklIUm9aU0IxYVc1ME5qUWdZMlZwYkdsdVp5d2dZV1owWlhJZ2QyaHBZMmdnWlhabGNua2dZSFJwWTJ0Z0lHOTJaWEptYkc5M2N5QmhibVFnY0dGdWFXTnpMZ29nSUNBZ0x5OGdJeUJVYUdVZ1FWWk5JSEJoYm1samN5QnlZWFJvWlhJZ2RHaGhiaUJ6WVhSMWNtRjBhVzVuTENCemJ5QjBhR1VnY0dGdWFXTWdabUZwYkhNZ2RHaGxJR2x1Ym1WeUNpQWdJQ0F2THlBaklHTmhiR3dzSUhkb2FXTm9JR1poYVd4eklIUm9aU0IzYUc5c1pTQmxlR1ZqZFhScGIyNHNJSGRvYVdOb0lHMWxZVzV6SUdFZ2EyVmxjR1Z5SUdOaGJpQnVaWFpsY2dvZ0lDQWdMeThnSXlCelpYSjJhV05sSUhSb2FYTWdZWEJ3SUdGbllXbHVMaUJVYUdGMElHbHpJR0VnY0dWeWJXRnVaVzUwSUhkbFpHZGxJRzltSUhSb1pTQmtaVzF2SUhSaGNtZGxkQW9nSUNBZ0x5OGdJeUJtYjNJZ2RHaGxJSEJ5YVdObElHOW1JRzl1WlNCMGNtRnVjMkZqZEdsdmJpd2dZVzVrSUc5dUlHRWdZMjl1ZEhKaFkzUWdkMmwwYUNCdWJ5QjFjR1JoZEdVS0lDQWdJQzh2SUNNZ2NHRjBhQ0IwYUdWeVpTQnBjeUJ1YnlCM1lYa2dZbUZqYXk0S0lDQWdJQzh2SUdGemMyVnlkQ0JpWldGMGN5QThQU0JOUVZoZlFrVkJWRk5mVUVWU1gxUkpRMHNzSUNKVWIyOGdiV0Z1ZVNCaVpXRjBjeUJtYjNJZ2IyNWxJSFJwWTJzaUNpQWdJQ0JrYVdjZ01Rb2dJQ0FnY0hWemFHbHVkQ0F4TURBd01EQXdDaUFnSUNBOFBRb2dJQ0FnWVhOelpYSjBJQzh2SUZSdmJ5QnRZVzU1SUdKbFlYUnpJR1p2Y2lCdmJtVWdkR2xqYXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM0IxYkhObEwyTnZiblJ5WVdOMExuQjVPalEzQ2lBZ0lDQXZMeUJ6Wld4bUxtSmxZWFJ6TG5aaGJIVmxJQ3M5SUdKbFlYUnpDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVltVmhkSE1pQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYMmRsZEY5bGVBb2dJQ0FnWVhOelpYSjBJQzh2SUdOb1pXTnJJSE5sYkdZdVltVmhkSE1nWlhocGMzUnpDaUFnSUNCMWJtTnZkbVZ5SURJS0lDQWdJQ3NLSUNBZ0lHSjVkR1ZqWHpBZ0x5OGdJbUpsWVhSeklnb2dJQ0FnYzNkaGNBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RXeHpaUzlqYjI1MGNtRmpkQzV3ZVRvME9Bb2dJQ0FnTHk4Z2MyVnNaaTVzWVhOMFgySmxZWFJmY205MWJtUXVkbUZzZFdVZ1BTQkhiRzlpWVd3dWNtOTFibVFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbXhoYzNSZlltVmhkRjl5YjNWdVpDSUtJQ0FnSUdkc2IySmhiQ0JTYjNWdVpBb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5d2RXeHpaUzlqYjI1MGNtRmpkQzV3ZVRvME9Rb2dJQ0FnTHk4Z2MyVnNaaTVzWVhOMFgyNXZkR1V1ZG1Gc2RXVWdQU0J1YjNSbExtNWhkR2wyWlFvZ0lDQWdaWGgwY21GamRDQXlJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbXhoYzNSZmJtOTBaU0lLSUNBZ0lITjNZWEFLSUNBZ0lHRndjRjluYkc5aVlXeGZjSFYwQ2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZjSFZzYzJVdlkyOXVkSEpoWTNRdWNIazZOVEFLSUNBZ0lDOHZJSEpsZEhWeWJpQnpaV3htTG1KbFlYUnpMblpoYkhWbENpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdZbmwwWldOZk1DQXZMeUFpWW1WaGRITWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1WW1WaGRITWdaWGhwYzNSekNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12Y0hWc2MyVXZZMjl1ZEhKaFkzUXVjSGs2TXpFS0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb0tRb2dJQ0FnYVhSdllnb2dJQ0FnWW5sMFpXTmZNeUF2THlBd2VERTFNV1kzWXpjMUNpQWdJQ0J6ZDJGd0NpQWdJQ0JqYjI1allYUUtJQ0FnSUd4dlp3b2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnbz0iLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QmhiR2R2Y0hrdVlYSmpOQzVCVWtNMFEyOXVkSEpoWTNRdVkyeGxZWEpmYzNSaGRHVmZjSEp2WjNKaGJTZ3BJQzArSUhWcGJuUTJORG9LYldGcGJqb0tJQ0FnSUhCMWMyaHBiblFnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDeUFDQUFFbUJBVmlaV0YwY3c5c1lYTjBYMkpsWVhSZmNtOTFibVFKYkdGemRGOXViM1JsQkJVZmZIVXhHRUFBQ2lnaVp5a2laeXFBQUdjeEcwRUFIVEVaRkVReEdFU0NBZ1JOVFY4TEJFNmtncm8yR2dDT0FnQUpBQ0VBTVJrVU1SZ1VFRU1pS0dWRUl3Z29UR2NwTWdabklpaGxSQllyVEZDd0kwTTJHZ0ZKRllFSUVrUVhOaG9DU1NKWmdRSUlTd0VWRWtSTEFZSEFoRDBPUkNJb1pVUlBBZ2dvVEdjcE1nWm5Wd0lBS2t4bklpaGxSQllyVEZDd0kwTT0iLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjo5LCJwYXRjaCI6MCwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
