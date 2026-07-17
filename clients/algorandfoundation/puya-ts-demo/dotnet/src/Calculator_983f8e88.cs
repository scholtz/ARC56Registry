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

namespace Arc56.Generated.algorandfoundation.puya_ts_demo.Calculator_983f8e88
{


    public class CalculatorProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public CalculatorProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
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

        ///<summary>
        ///A method that takes two numbers and does either addition or subtraction
        ///</summary>
        /// <param name="a">The first number </param>
        /// <param name="b">The second number </param>
        /// <param name="operation">The operation to perform. Can be either 'sum' or 'difference' </param>
        public async Task<ulong> DoMath(ulong a, ulong b, string operation, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 167, 239, 51 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var operationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); operationAbi.From(operation);

            var result = await base.CallApp(new List<object> { abiHandle, aAbi, bAbi, operationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64();
            returnValueObj.Decode(lastLogReturnData);
            return BitConverter.ToUInt64(ReverseIfLittleEndian(lastLogReturnData), 0);

        }

        public async Task<List<Transaction>> DoMath_Transactions(ulong a, ulong b, string operation, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 118, 167, 239, 51 };
            var aAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); aAbi.From(a);
            var bAbi = new AVM.ClientGenerator.ABI.ARC4.Types.UInt64(); bAbi.From(b);
            var operationAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); operationAbi.From(operation);

            return await base.MakeTransactionList(new List<object> { abiHandle, aAbi, bAbi, operationAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        protected override ulong? ExtraProgramPages { get; set; } = 0;
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiQ2FsY3VsYXRvciIsImRlc2MiOm51bGwsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6e30sIk1ldGhvZHMiOlt7Im5hbWUiOiJjcmVhdGVBcHBsaWNhdGlvbiIsImRlc2MiOm51bGwsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOlsiTm9PcCJdLCJjYWxsIjpbXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fSx7Im5hbWUiOiJkb01hdGgiLCJkZXNjIjoiQSBtZXRob2QgdGhhdCB0YWtlcyB0d28gbnVtYmVycyBhbmQgZG9lcyBlaXRoZXIgYWRkaXRpb24gb3Igc3VidHJhY3Rpb24iLCJhcmdzIjpbeyJ0eXBlIjoidWludDY0Iiwic3RydWN0IjpudWxsLCJuYW1lIjoiYSIsImRlc2MiOiJUaGUgZmlyc3QgbnVtYmVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJiIiwiZGVzYyI6IlRoZSBzZWNvbmQgbnVtYmVyIiwiZGVmYXVsdFZhbHVlIjpudWxsfSx7InR5cGUiOiJzdHJpbmciLCJzdHJ1Y3QiOm51bGwsIm5hbWUiOiJvcGVyYXRpb24iLCJkZXNjIjoiVGhlIG9wZXJhdGlvbiB0byBwZXJmb3JtLiBDYW4gYmUgZWl0aGVyICdzdW0nIG9yICdkaWZmZXJlbmNlJyIsImRlZmF1bHRWYWx1ZSI6bnVsbH1dLCJyZXR1cm5zIjp7InR5cGUiOiJ1aW50NjQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOiJUaGUgcmVzdWx0IG9mIHRoZSBvcGVyYXRpb24ifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MCwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjowLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6Wzk3XSwiZXJyb3JNZXNzYWdlIjoiSW52YWxpZCBvcGVyYXRpb24iLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls0XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV3Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCQVlXeG5iM0poYm1SbWIzVnVaR0YwYVc5dUwyRnNaMjl5WVc1a0xYUjVjR1Z6WTNKcGNIUXZZWEpqTkM5cGJtUmxlQzVrTG5Sek9qcERiMjUwY21GamRDNWhjSEJ5YjNaaGJGQnliMmR5WVcwb0tTQXRQaUIxYVc1ME5qUTZDbTFoYVc0NkNpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyRnNZM1ZzWVhSdmNpOWpZV3hqZFd4aGRHOXlMbUZzWjI4dWRITTZPQW9nSUNBZ0x5OGdaWGh3YjNKMElHTnNZWE56SUVOaGJHTjFiR0YwYjNJZ1pYaDBaVzVrY3lCRGIyNTBjbUZqZENCN0NpQWdJQ0IwZUc0Z1QyNURiMjF3YkdWMGFXOXVDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQW9nSUNBZ2RIaHVJRUZ3Y0d4cFkyRjBhVzl1U1VRS0lDQWdJR0o2SUcxaGFXNWZZM0psWVhSbFgwNXZUM0JBTlFvZ0lDQWdjSFZ6YUdKNWRHVnpJREI0TnpaaE4yVm1Nek1nTHk4Z2JXVjBhRzlrSUNKa2IwMWhkR2dvZFdsdWREWTBMSFZwYm5RMk5DeHpkSEpwYm1jcGRXbHVkRFkwSWdvZ0lDQWdkSGh1WVNCQmNIQnNhV05oZEdsdmJrRnlaM01nTUFvZ0lDQWdiV0YwWTJnZ1pHOU5ZWFJvQ2lBZ0lDQmxjbklLQ20xaGFXNWZZM0psWVhSbFgwNXZUM0JBTlRvS0lDQWdJQzh2SUdOdmJuUnlZV04wY3k5allXeGpkV3hoZEc5eUwyTmhiR04xYkdGMGIzSXVZV3huYnk1MGN6bzRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUTJGc1kzVnNZWFJ2Y2lCbGVIUmxibVJ6SUVOdmJuUnlZV04wSUhzS0lDQWdJSEIxYzJoaWVYUmxjeUF3ZUdJNE5EUTNZak0ySUM4dklHMWxkR2h2WkNBaVkzSmxZWFJsUVhCd2JHbGpZWFJwYjI0b0tYWnZhV1FpQ2lBZ0lDQjBlRzVoSUVGd2NHeHBZMkYwYVc5dVFYSm5jeUF3Q2lBZ0lDQnRZWFJqYUNCdFlXbHVYMk55WldGMFpVRndjR3hwWTJGMGFXOXVYM0p2ZFhSbFFEWUtJQ0FnSUdWeWNnb0tiV0ZwYmw5amNtVmhkR1ZCY0hCc2FXTmhkR2x2Ymw5eWIzVjBaVUEyT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOaGJHTjFiR0YwYjNJdlkyRnNZM1ZzWVhSdmNpNWhiR2R2TG5Sek9qa0tJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUW9leUJ2YmtOeVpXRjBaVG9nSW5KbGNYVnBjbVVpSUgwcENpQWdJQ0J3ZFhOb2FXNTBJREVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZ29LTHk4Z1kyOXVkSEpoWTNSekwyTmhiR04xYkdGMGIzSXZZMkZzWTNWc1lYUnZjaTVoYkdkdkxuUnpPanBEWVd4amRXeGhkRzl5TG1SdlRXRjBhRnR5YjNWMGFXNW5YU2dwSUMwK0lIWnZhV1E2Q21SdlRXRjBhRG9LSUNBZ0lDOHZJR052Ym5SeVlXTjBjeTlqWVd4amRXeGhkRzl5TDJOaGJHTjFiR0YwYjNJdVlXeG5ieTUwY3pvME13b2dJQ0FnTHk4Z1pHOU5ZWFJvS0dFNklIVnBiblEyTkN3Z1lqb2dkV2x1ZERZMExDQnZjR1Z5WVhScGIyNDZJSE4wY21sdVp5azZJSFZwYm5RMk5DQjdDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXhDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXlDaUFnSUNCaWRHOXBDaUFnSUNCMGVHNWhJRUZ3Y0d4cFkyRjBhVzl1UVhKbmN5QXpDaUFnSUNCbGVIUnlZV04wSURJZ01Bb2dJQ0FnWkhWd0NpQWdJQ0F2THlCamIyNTBjbUZqZEhNdlkyRnNZM1ZzWVhSdmNpOWpZV3hqZFd4aGRHOXlMbUZzWjI4dWRITTZORFlLSUNBZ0lDOHZJR2xtSUNodmNHVnlZWFJwYjI0Z1BUMDlJQ0p6ZFcwaUtTQjdDaUFnSUNCd2RYTm9ZbmwwWlhNZ0luTjFiU0lLSUNBZ0lEMDlDaUFnSUNCaWVpQmtiMDFoZEdoZlpXeHpaVjlpYjJSNVFETUtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpZV3hqZFd4aGRHOXlMMk5oYkdOMWJHRjBiM0l1WVd4bmJ5NTBjem95TUFvZ0lDQWdMeThnY21WMGRYSnVJR0VnS3lCaU93b2dJQ0FnWkdsbklESUtJQ0FnSUdScFp5QXlDaUFnSUNBckNncGtiMDFoZEdoZllXWjBaWEpmYVdaZlpXeHpaVUEzT2dvZ0lDQWdMeThnWTI5dWRISmhZM1J6TDJOaGJHTjFiR0YwYjNJdlkyRnNZM1ZzWVhSdmNpNWhiR2R2TG5Sek9qUXpDaUFnSUNBdkx5QmtiMDFoZEdnb1lUb2dkV2x1ZERZMExDQmlPaUIxYVc1ME5qUXNJRzl3WlhKaGRHbHZiam9nYzNSeWFXNW5LVG9nZFdsdWREWTBJSHNLSUNBZ0lHbDBiMklLSUNBZ0lIQjFjMmhpZVhSbGN5QXdlREUxTVdZM1l6YzFDaUFnSUNCemQyRndDaUFnSUNCamIyNWpZWFFLSUNBZ0lHeHZad29nSUNBZ2NIVnphR2x1ZENBeElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS1pHOU5ZWFJvWDJWc2MyVmZZbTlrZVVBek9nb2dJQ0FnTHk4Z1kyOXVkSEpoWTNSekwyTmhiR04xYkdGMGIzSXZZMkZzWTNWc1lYUnZjaTVoYkdkdkxuUnpPalE0Q2lBZ0lDQXZMeUI5SUdWc2MyVWdhV1lnS0c5d1pYSmhkR2x2YmlBOVBUMGdJbVJwWm1abGNtVnVZMlVpS1NCN0NpQWdJQ0JrZFhBS0lDQWdJSEIxYzJoaWVYUmxjeUFpWkdsbVptVnlaVzVqWlNJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQnZjR1Z5WVhScGIyNEtJQ0FnSUM4dklHTnZiblJ5WVdOMGN5OWpZV3hqZFd4aGRHOXlMMk5oYkdOMWJHRjBiM0l1WVd4bmJ5NTBjem96TVFvZ0lDQWdMeThnY21WMGRYSnVJR0VnUGowZ1lpQS9JR0VnTFNCaUlEb2dZaUF0SUdFN0NpQWdJQ0JrYVdjZ01nb2dJQ0FnWkdsbklESUtJQ0FnSUQ0OUNpQWdJQ0JpZWlCa2IwMWhkR2hmZEdWeWJtRnllVjltWVd4elpVQXhNQW9nSUNBZ1pHbG5JRElLSUNBZ0lHUnBaeUF5Q2lBZ0lDQXRDaUFnSUNCaUlHUnZUV0YwYUY5aFpuUmxjbDlwWmw5bGJITmxRRGNLQ21SdlRXRjBhRjkwWlhKdVlYSjVYMlpoYkhObFFERXdPZ29nSUNBZ0x5OGdZMjl1ZEhKaFkzUnpMMk5oYkdOMWJHRjBiM0l2WTJGc1kzVnNZWFJ2Y2k1aGJHZHZMblJ6T2pNeENpQWdJQ0F2THlCeVpYUjFjbTRnWVNBK1BTQmlJRDhnWVNBdElHSWdPaUJpSUMwZ1lUc0tJQ0FnSUdScFp5QXhDaUFnSUNCa2FXY2dNd29nSUNBZ0xRb2dJQ0FnWWlCa2IwMWhkR2hmWVdaMFpYSmZhV1pmWld4elpVQTNDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXdDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdlltRnpaUzFqYjI1MGNtRmpkQzVrTG5Sek9qcENZWE5sUTI5dWRISmhZM1F1WTJ4bFlYSlRkR0YwWlZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQndkWE5vYVc1MElERWdMeThnTVFvZ0lDQWdjbVYwZFhKdUNnPT0ifSwiYnl0ZUNvZGUiOnsiYXBwcm92YWwiOiJDakVaRkVReEdFRUFEb0FFZHFmdk16WWFBSTRCQUJJQWdBUzRSSHMyTmhvQWpnRUFBUUNCQVVNMkdnRVhOaG9DRnpZYUExY0NBRW1BQTNOMWJSSkJBQkpMQWtzQ0NCYUFCQlVmZkhWTVVMQ0JBVU5KZ0Fwa2FXWm1aWEpsYm1ObEVrUkxBa3NDRDBFQUNFc0NTd0lKUXYvVVN3RkxBd2xDLzh3PSIsImNsZWFyIjoiQ29FQlF3PT0ifSwiY29tcGlsZXJJbmZvIjp7ImNvbXBpbGVyIjoicHV5YSIsImNvbXBpbGVyVmVyc2lvbiI6eyJtYWpvciI6NSwibWlub3IiOjAsInBhdGNoIjowLCJjb21taXRIYXNoIjpudWxsfX0sImV2ZW50cyI6W10sInRlbXBsYXRlVmFyaWFibGVzIjp7fSwic2NyYXRjaFZhcmlhYmxlcyI6e319";
    }

}
