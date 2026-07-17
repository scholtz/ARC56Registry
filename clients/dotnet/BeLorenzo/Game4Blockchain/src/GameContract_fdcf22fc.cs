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

namespace Arc56.Generated.BeLorenzo.Game4Blockchain.GameContract_fdcf22fc
{


    //
    // Abstract contract implementing a generic Commit-Reveal scheme for N-player games.
    //
    //Implements the full lifecycle:
    //1. Creation (MBR reservation)
    //2. Joining (Commit hash + MBR reservation)
    //3. Revealing (Verifying hash against choice)
    //
    //Supports both single-round and multi-round (elimination) logic.
    //
    public class GameContractProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public GameContractProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class ObjectB555233E : AVMObjectType
            {
                public ulong StartAt { get; set; }

                public ulong EndCommitAt { get; set; }

                public ulong EndRevealAt { get; set; }

                public ulong Participation { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vStartAt.From(StartAt);
                    ret.AddRange(vStartAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndCommitAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEndCommitAt.From(EndCommitAt);
                    ret.AddRange(vEndCommitAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndRevealAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vEndRevealAt.From(EndRevealAt);
                    ret.AddRange(vEndRevealAt.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vParticipation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vParticipation.From(Participation);
                    ret.AddRange(vParticipation.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static ObjectB555233E Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new ObjectB555233E();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vStartAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vStartAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueStartAt = vStartAt.ToValue();
                    if (valueStartAt is ulong vStartAtValue) { ret.StartAt = vStartAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndCommitAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEndCommitAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEndCommitAt = vEndCommitAt.ToValue();
                    if (valueEndCommitAt is ulong vEndCommitAtValue) { ret.EndCommitAt = vEndCommitAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vEndRevealAt = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vEndRevealAt.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueEndRevealAt = vEndRevealAt.ToValue();
                    if (valueEndRevealAt is ulong vEndRevealAtValue) { ret.EndRevealAt = vEndRevealAtValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vParticipation = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vParticipation.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueParticipation = vParticipation.ToValue();
                    if (valueParticipation is ulong vParticipationValue) { ret.Participation = vParticipationValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as ObjectB555233E);
                }
                public bool Equals(ObjectB555233E? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(ObjectB555233E left, ObjectB555233E right)
                {
                    return EqualityComparer<ObjectB555233E>.Default.Equals(left, right);
                }
                public static bool operator !=(ObjectB555233E left, ObjectB555233E right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Returns contract identification info.
        ///</summary>
        public async Task<byte[]> GetGameType(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 131, 238, 8 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            var lastLogReturnData = lastLogBytes.Skip(4).ToArray();
            var returnValueObj = new AVM.ClientGenerator.ABI.ARC4.Types.VariableArray<AVM.ClientGenerator.ABI.ARC4.Types.Byte>("byte");
            returnValueObj.Decode(lastLogReturnData);
            return returnValueObj.ToByteArray();

        }

        public async Task<List<Transaction>> GetGameType_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 86, 131, 238, 8 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Sets the game type. Immutable once set.
        ///Can only be called by the creator.
        ///</summary>
        /// <param name="gameType"> </param>
        public async Task Initialize(string gameType, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 243, 57, 231 };
            var gameTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); gameTypeAbi.From(gameType);

            var result = await base.CallApp(new List<object> { abiHandle, gameTypeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Initialize_Transactions(string gameType, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 236, 243, 57, 231 };
            var gameTypeAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); gameTypeAbi.From(gameType);

            return await base.MakeTransactionList(new List<object> { abiHandle, gameTypeAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiR2FtZUNvbnRyYWN0IiwiZGVzYyI6IkFic3RyYWN0IGNvbnRyYWN0IGltcGxlbWVudGluZyBhIGdlbmVyaWMgQ29tbWl0LVJldmVhbCBzY2hlbWUgZm9yIE4tcGxheWVyIGdhbWVzLlxuXG5JbXBsZW1lbnRzIHRoZSBmdWxsIGxpZmVjeWNsZTpcbjEuIENyZWF0aW9uIChNQlIgcmVzZXJ2YXRpb24pXG4yLiBKb2luaW5nIChDb21taXQgaGFzaCArIE1CUiByZXNlcnZhdGlvbilcbjMuIFJldmVhbGluZyAoVmVyaWZ5aW5nIGhhc2ggYWdhaW5zdCBjaG9pY2UpXG5cblN1cHBvcnRzIGJvdGggc2luZ2xlLXJvdW5kIGFuZCBtdWx0aS1yb3VuZCAoZWxpbWluYXRpb24pIGxvZ2ljLiIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJPYmplY3RCNTU1MjMzRSI6W3sibmFtZSI6InN0YXJ0QXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZW5kQ29tbWl0QXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoiZW5kUmV2ZWFsQXQiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoicGFydGljaXBhdGlvbiIsInR5cGUiOiJ1aW50NjQifV19LCJNZXRob2RzIjpbeyJuYW1lIjoiZ2V0R2FtZVR5cGUiLCJkZXNjIjoiUmV0dXJucyBjb250cmFjdCBpZGVudGlmaWNhdGlvbiBpbmZvLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJieXRlW10iLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImluaXRpYWxpemUiLCJkZXNjIjoiU2V0cyB0aGUgZ2FtZSB0eXBlLiBJbW11dGFibGUgb25jZSBzZXQuXG5DYW4gb25seSBiZSBjYWxsZWQgYnkgdGhlIGNyZWF0b3IuIiwiYXJncyI6W3sidHlwZSI6InN0cmluZyIsInN0cnVjdCI6bnVsbCwibmFtZSI6ImdhbWVUeXBlIiwiZGVzYyI6bnVsbCwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19XSwic3RhdGUiOnsic2NoZW1hIjp7Imdsb2JhbCI6eyJpbnRzIjoxLCJieXRlcyI6MX0sImxvY2FsIjp7ImludHMiOjAsImJ5dGVzIjowfX0sImtleXMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwibG9jYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsImtleSI6IiJ9fSwibWFwcyI6eyJnbG9iYWwiOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJib3giOnsiZGVzYyI6bnVsbCwia2V5VHlwZSI6IiIsInZhbHVlVHlwZSI6IiIsInByZWZpeCI6bnVsbH19fSwiYmFyZUFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJzb3VyY2VJbmZvIjp7ImFwcHJvdmFsIjp7InNvdXJjZUluZm8iOlt7InBjIjpbMTM1XSwiZXJyb3JNZXNzYWdlIjoiQ29udHJhY3QgYWxyZWFkeSBpbml0aWFsaXplZCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6WzUzXSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH0seyJwYyI6Wzg2XSwiZXJyb3JNZXNzYWdlIjoiT25Db21wbGV0aW9uIG11c3QgYmUgTm9PcCAmJiBjYW4gb25seSBjYWxsIHdoZW4gY3JlYXRpbmciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNDFdLCJlcnJvck1lc3NhZ2UiOiJPbmx5IGNyZWF0b3IgY2FuIGluaXRpYWxpemUiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls5MiwxMzJdLCJlcnJvck1lc3NhZ2UiOiJjaGVjayBHbG9iYWxTdGF0ZSBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTddLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIGFycmF5IGxlbmd0aCBoZWFkZXIiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMjVdLCJlcnJvck1lc3NhZ2UiOiJpbnZhbGlkIG51bWJlciBvZiBieXRlcyBmb3IgYXJjNC5keW5hbWljX2FycmF5PGFyYzQudWludDg+IiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfV0sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9LCJjbGVhciI6eyJzb3VyY2VJbmZvIjpbXSwicGNPZmZzZXRNZXRob2QiOiJub25lIn19LCJzb3VyY2UiOnsiYXBwcm92YWwiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJBWVd4bmIzSmhibVJtYjNWdVpHRjBhVzl1TDJGc1oyOXlZVzVrTFhSNWNHVnpZM0pwY0hRdllYSmpOQzlwYm1SbGVDNWtMblJ6T2pwRGIyNTBjbUZqZEM1aGNIQnliM1poYkZCeWIyZHlZVzBvS1NBdFBpQjFhVzUwTmpRNkNtMWhhVzQ2Q2lBZ0lDQnBiblJqWW14dlkyc2dNQ0F4Q2lBZ0lDQmllWFJsWTJKc2IyTnJJQ0puWVcxbFZIbHdaU0lLSUNBZ0lIUjRiaUJCY0hCc2FXTmhkR2x2YmtsRUNpQWdJQ0JpYm5vZ2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFluTjBjbUZqZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRMENpQWdJQ0F2THlCbllXMWxWSGx3WlNBOUlFZHNiMkpoYkZOMFlYUmxQR0o1ZEdWelBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ1FubDBaWE1vSnljcElIMHBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSm5ZVzFsVkhsd1pTSUtJQ0FnSUhCMWMyaGllWFJsY3lBaUlnb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5aFluTjBjbUZqZEY5amIyNTBjbUZqZEM5amIyNTBjbUZqZEM1aGJHZHZMblJ6T2pRNUNpQWdJQ0F2THlCelpYTnphVzl1U1VSRGIzVnVkR1Z5SUQwZ1IyeHZZbUZzVTNSaGRHVThkV2x1ZERZMFBpaDdJR2x1YVhScFlXeFdZV3gxWlRvZ01DQjlLUW9nSUNBZ2NIVnphR0o1ZEdWeklDSnpaWE56YVc5dVNVUkRiM1Z1ZEdWeUlnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENncHRZV2x1WDJGbWRHVnlYMmxtWDJWc2MyVkFNam9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbk4wY21GamRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUjJGdFpVTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFNTFiVUZ3Y0VGeVozTUtJQ0FnSUdKNklHMWhhVzVmWDE5aGJHZHZkSE5mWHk1a1pXWmhkV3gwUTNKbFlYUmxRREV4Q2lBZ0lDQjBlRzRnVDI1RGIyMXdiR1YwYVc5dUNpQWdJQ0FoQ2lBZ0lDQmhjM05sY25RZ0x5OGdUMjVEYjIxd2JHVjBhVzl1SUcxMWMzUWdZbVVnVG05UGNBb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHRnpjMlZ5ZEFvZ0lDQWdjSFZ6YUdKNWRHVnpjeUF3ZURVMk9ETmxaVEE0SURCNFpXTm1Nek01WlRjZ0x5OGdiV1YwYUc5a0lDSm5aWFJIWVcxbFZIbHdaU2dwWW5sMFpWdGRJaXdnYldWMGFHOWtJQ0pwYm1sMGFXRnNhWHBsS0hOMGNtbHVaeWwyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2daMlYwUjJGdFpWUjVjR1VnYVc1cGRHbGhiR2w2WlFvZ0lDQWdaWEp5Q2dwdFlXbHVYMTlmWVd4bmIzUnpYMTh1WkdWbVlYVnNkRU55WldGMFpVQXhNVG9LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OWhZbk4wY21GamRGOWpiMjUwY21GamRDOWpiMjUwY21GamRDNWhiR2R2TG5Sek9qTTRDaUFnSUNBdkx5QmxlSEJ2Y25RZ1kyeGhjM01nUjJGdFpVTnZiblJ5WVdOMElHVjRkR1Z1WkhNZ1EyOXVkSEpoWTNRZ2V3b2dJQ0FnZEhodUlFOXVRMjl0Y0d4bGRHbHZiZ29nSUNBZ0lRb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lDRUtJQ0FnSUNZbUNpQWdJQ0JoYzNObGNuUWdMeThnVDI1RGIyMXdiR1YwYVc5dUlHMTFjM1FnWW1VZ1RtOVBjQ0FtSmlCallXNGdiMjVzZVNCallXeHNJSGRvWlc0Z1kzSmxZWFJwYm1jS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0p6ZEhKaFkzUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSMkZ0WlVOdmJuUnlZV04wTG1kbGRFZGhiV1ZVZVhCbFczSnZkWFJwYm1kZEtDa2dMVDRnZG05cFpEb0taMlYwUjJGdFpWUjVjR1U2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0p6ZEhKaFkzUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzNPUW9nSUNBZ0x5OGdjbVYwZFhKdUlIUm9hWE11WjJGdFpWUjVjR1V1ZG1Gc2RXVUtJQ0FnSUdsdWRHTmZNQ0F2THlBd0NpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdKemRISmhZM1JmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8wTkFvZ0lDQWdMeThnWjJGdFpWUjVjR1VnUFNCSGJHOWlZV3hUZEdGMFpUeGllWFJsY3o0b2V5QnBibWwwYVdGc1ZtRnNkV1U2SUVKNWRHVnpLQ2NuS1NCOUtRb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaVoyRnRaVlI1Y0dVaUNpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12WVdKemRISmhZM1JmWTI5dWRISmhZM1F2WTI5dWRISmhZM1F1WVd4bmJ5NTBjem8zT1FvZ0lDQWdMeThnY21WMGRYSnVJSFJvYVhNdVoyRnRaVlI1Y0dVdWRtRnNkV1VLSUNBZ0lHRndjRjluYkc5aVlXeGZaMlYwWDJWNENpQWdJQ0JoYzNObGNuUWdMeThnWTJobFkyc2dSMnh2WW1Gc1UzUmhkR1VnWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdllXSnpkSEpoWTNSZlkyOXVkSEpoWTNRdlkyOXVkSEpoWTNRdVlXeG5ieTUwY3pvM09Bb2dJQ0FnTHk4Z2NIVmliR2xqSUdkbGRFZGhiV1ZVZVhCbEtDazZJR0o1ZEdWeklIc0tJQ0FnSUdSMWNBb2dJQ0FnYkdWdUNpQWdJQ0JwZEc5aUNpQWdJQ0JsZUhSeVlXTjBJRFlnTWdvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0J3ZFhOb1lubDBaWE1nTUhneE5URm1OMk0zTlFvZ0lDQWdjM2RoY0FvZ0lDQWdZMjl1WTJGMENpQWdJQ0JzYjJjS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0p6ZEhKaFkzUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzZSMkZ0WlVOdmJuUnlZV04wTG1sdWFYUnBZV3hwZW1WYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncHBibWwwYVdGc2FYcGxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwyRmljM1J5WVdOMFgyTnZiblJ5WVdOMEwyTnZiblJ5WVdOMExtRnNaMjh1ZEhNNk9EWUtJQ0FnSUM4dklIQjFZbXhwWXlCcGJtbDBhV0ZzYVhwbEtHZGhiV1ZVZVhCbE9pQnpkSEpwYm1jcE9pQjJiMmxrSUhzS0lDQWdJSFI0Ym1FZ1FYQndiR2xqWVhScGIyNUJjbWR6SURFS0lDQWdJR1IxY0FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHVjRkSEpoWTNSZmRXbHVkREUySUM4dklHOXVJR1Z5Y205eU9pQnBiblpoYkdsa0lHRnljbUY1SUd4bGJtZDBhQ0JvWldGa1pYSUtJQ0FnSUhCMWMyaHBiblFnTWlBdkx5QXlDaUFnSUNBckNpQWdJQ0JrYVdjZ01Rb2dJQ0FnYkdWdUNpQWdJQ0E5UFFvZ0lDQWdZWE56WlhKMElDOHZJR2x1ZG1Gc2FXUWdiblZ0WW1WeUlHOW1JR0o1ZEdWeklHWnZjaUJoY21NMExtUjVibUZ0YVdOZllYSnlZWGs4WVhKak5DNTFhVzUwT0Q0S0lDQWdJR1Y0ZEhKaFkzUWdNaUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZZV0p6ZEhKaFkzUmZZMjl1ZEhKaFkzUXZZMjl1ZEhKaFkzUXVZV3huYnk1MGN6bzROd29nSUNBZ0x5OGdZWE56WlhKMEtIUm9hWE11WjJGdFpWUjVjR1V1ZG1Gc2RXVXViR1Z1WjNSb0lEMDlQU0F3TENBblEyOXVkSEpoWTNRZ1lXeHlaV0ZrZVNCcGJtbDBhV0ZzYVhwbFpDY3BDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaWMzUnlZV04wWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02TkRRS0lDQWdJQzh2SUdkaGJXVlVlWEJsSUQwZ1IyeHZZbUZzVTNSaGRHVThZbmwwWlhNK0tIc2dhVzVwZEdsaGJGWmhiSFZsT2lCQ2VYUmxjeWduSnlrZ2ZTa0tJQ0FnSUdKNWRHVmpYekFnTHk4Z0ltZGhiV1ZVZVhCbElnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDJGaWMzUnlZV04wWDJOdmJuUnlZV04wTDJOdmJuUnlZV04wTG1Gc1oyOHVkSE02T0RjS0lDQWdJQzh2SUdGemMyVnlkQ2gwYUdsekxtZGhiV1ZVZVhCbExuWmhiSFZsTG14bGJtZDBhQ0E5UFQwZ01Dd2dKME52Ym5SeVlXTjBJR0ZzY21WaFpIa2dhVzVwZEdsaGJHbDZaV1FuS1FvZ0lDQWdZWEJ3WDJkc2IySmhiRjluWlhSZlpYZ0tJQ0FnSUdGemMyVnlkQ0F2THlCamFHVmpheUJIYkc5aVlXeFRkR0YwWlNCbGVHbHpkSE1LSUNBZ0lHeGxiZ29nSUNBZ0lRb2dJQ0FnWVhOelpYSjBJQzh2SUVOdmJuUnlZV04wSUdGc2NtVmhaSGtnYVc1cGRHbGhiR2w2WldRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW5OMGNtRmpkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamc0Q2lBZ0lDQXZMeUJoYzNObGNuUW9WSGh1TG5ObGJtUmxjaUE5UFQwZ1IyeHZZbUZzTG1OeVpXRjBiM0pCWkdSeVpYTnpMQ0FuVDI1c2VTQmpjbVZoZEc5eUlHTmhiaUJwYm1sMGFXRnNhWHBsSnlrS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lHZHNiMkpoYkNCRGNtVmhkRzl5UVdSa2NtVnpjd29nSUNBZ1BUMEtJQ0FnSUdGemMyVnlkQ0F2THlCUGJteDVJR055WldGMGIzSWdZMkZ1SUdsdWFYUnBZV3hwZW1VS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW5OMGNtRmpkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPalEwQ2lBZ0lDQXZMeUJuWVcxbFZIbHdaU0E5SUVkc2IySmhiRk4wWVhSbFBHSjVkR1Z6UGloN0lHbHVhWFJwWVd4V1lXeDFaVG9nUW5sMFpYTW9KeWNwSUgwcENpQWdJQ0JpZVhSbFkxOHdJQzh2SUNKbllXMWxWSGx3WlNJS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTloWW5OMGNtRmpkRjlqYjI1MGNtRmpkQzlqYjI1MGNtRmpkQzVoYkdkdkxuUnpPamc1Q2lBZ0lDQXZMeUIwYUdsekxtZGhiV1ZVZVhCbExuWmhiSFZsSUQwZ1FubDBaWE1vWjJGdFpWUjVjR1VwQ2lBZ0lDQnpkMkZ3Q2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMMkZpYzNSeVlXTjBYMk52Ym5SeVlXTjBMMk52Ym5SeVlXTjBMbUZzWjI4dWRITTZPRFlLSUNBZ0lDOHZJSEIxWW14cFl5QnBibWwwYVdGc2FYcGxLR2RoYldWVWVYQmxPaUJ6ZEhKcGJtY3BPaUIyYjJsa0lIc0tJQ0FnSUdsdWRHTmZNU0F2THlBeENpQWdJQ0J5WlhSMWNtNEsiLCJjbGVhciI6IkkzQnlZV2R0WVNCMlpYSnphVzl1SURFeENpTndjbUZuYldFZ2RIbHdaWFJ5WVdOcklHWmhiSE5sQ2dvdkx5QkFZV3huYjNKaGJtUm1iM1Z1WkdGMGFXOXVMMkZzWjI5eVlXNWtMWFI1Y0dWelkzSnBjSFF2WW1GelpTMWpiMjUwY21GamRDNWtMblJ6T2pwQ1lYTmxRMjl1ZEhKaFkzUXVZMnhsWVhKVGRHRjBaVkJ5YjJkeVlXMG9LU0F0UGlCMWFXNTBOalE2Q20xaGFXNDZDaUFnSUNCd2RYTm9hVzUwSURFZ0x5OGdNUW9nSUNBZ2NtVjBkWEp1Q2c9PSJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBQUVtQVFobllXMWxWSGx3WlRFWVFBQVlLSUFBWjRBUWMyVnpjMmx2YmtsRVEyOTFiblJsY2lKbk1SdEJBQjB4R1JSRU1SaEVnZ0lFVm9QdUNBVHM4em5uTmhvQWpnSUFDd0FpQURFWkZERVlGQkJFSTBNaUtHVkVTUlVXVndZQ1RGQ0FCQlVmZkhWTVVMQWpRellhQVVraVdZRUNDRXNCRlJKRVZ3SUFJaWhsUkJVVVJERUFNZ2tTUkNoTVp5TkQiLCJjbGVhciI6IkM0RUJRdz09In0sImNvbXBpbGVySW5mbyI6eyJjb21waWxlciI6InB1eWEiLCJjb21waWxlclZlcnNpb24iOnsibWFqb3IiOjUsIm1pbm9yIjozLCJwYXRjaCI6MiwiY29tbWl0SGFzaCI6bnVsbH19LCJldmVudHMiOltdLCJ0ZW1wbGF0ZVZhcmlhYmxlcyI6e30sInNjcmF0Y2hWYXJpYWJsZXMiOnt9fQ==";
    }

}
