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

namespace Arc56.Generated.SimonYuvarlak.Algorand_Course.VotingPoll_b067c4ba
{


    //
    // 
    //    VotingPoll – a minimal, best‑practice Algorand Python contract.
    //
    //    This contract demonstrates:
    //
    //    1. EXPLICIT TYPES EVERYWHERE
    //       - All on-chain state uses algopy.UInt64 / algopy.String,
    //         never bare int/str.
    //       - Method parameters and return values are typed.
    //
    //    2. FAMILIAR PYTHON CONSTRUCTS
    //       - We still use __init__, NamedTuple, if/elif/else, and assert,
    //         so the code reads like normal Python.
    //
    //    3. AVM RESTRICTIONS ARE RESPECTED
    //       - The AVM doesn’t have a native bool type, so we model booleans
    //         as UInt64(0) and UInt64(1).
    //       - We use assert to handle invalid situations, which compiles
    //         down to a safe AVM error.
    //
    //    4. STATIC TYPING PREVENTS ERRORS
    //       - We declare state on self in __init__, so the compiler understands
    //         each field’s type.
    //       - Misusing APIs (for example, calling .get() on a UInt64 instead
    //         of a LocalState) becomes a compile‑time error instead of a
    //         hidden runtime bug.
    //    
    //
    public class VotingPollProxy : ProxyBase
    {
        public override AppDescriptionArc56 App { get; set; }

        public VotingPollProxy(DefaultApi defaultApi, ulong appId) : base(defaultApi, appId)
        {
            App = Newtonsoft.Json.JsonConvert.DeserializeObject<AVM.ClientGenerator.ABI.ARC56.AppDescriptionArc56>(Encoding.UTF8.GetString(Convert.FromBase64String(_ARC56DATA))) ?? throw new Exception("Error reading ARC56 data");

        }

        public class Structs
        {
            public class VoteTally : AVMObjectType
            {
                public ulong Yes { get; set; }

                public ulong No { get; set; }

                public byte[] ToByteArray()
                {
                    var ret = new List<byte>();
                    var stringRef = new Dictionary<int, byte[]>();
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vYes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vYes.From(Yes);
                    ret.AddRange(vYes.Encode());
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    vNo.From(No);
                    ret.AddRange(vNo.Encode());
                    foreach (var item in stringRef)
                    {
                        var b1 = ret.Count;
                        ret[item.Key] = Convert.ToByte(b1 / 256);
                        ret[item.Key + 1] = Convert.ToByte(b1 % 256);
                        ret.AddRange(item.Value);
                    }
                    return ret.ToArray();

                }

                public static VoteTally Parse(byte[] bytes)
                {
                    var queue = new Queue<byte>(bytes);
                    var ret = new VoteTally();
                    uint count = 0;
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vYes = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vYes.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueYes = vYes.ToValue();
                    if (valueYes is ulong vYesValue) { ret.Yes = vYesValue; }
                    AVM.ClientGenerator.ABI.ARC4.Types.WireType vNo = AVM.ClientGenerator.ABI.ARC4.Types.WireType.FromABIDescription("uint64");
                    count = vNo.Decode(queue.ToArray());
                    for (int i = 0; i < Convert.ToInt32(count); i++) { queue.Dequeue(); }
                    var valueNo = vNo.ToValue();
                    if (valueNo is ulong vNoValue) { ret.No = vNoValue; }
                    return ret;

                }

                public override string ToString()
                {
                    return $"{this.GetType().ToString()} {BitConverter.ToString(ToByteArray()).Replace("-", "")}";
                }
                public override bool Equals(object? obj)
                {
                    return Equals(obj as VoteTally);
                }
                public bool Equals(VoteTally? other)
                {
                    return other is not null && ToByteArray().SequenceEqual(other.ToByteArray());
                }
                public override int GetHashCode()
                {
                    return ToByteArray().GetHashCode();
                }
                public static bool operator ==(VoteTally left, VoteTally right)
                {
                    return EqualityComparer<VoteTally>.Default.Equals(left, right);
                }
                public static bool operator !=(VoteTally left, VoteTally right)
                {
                    return !(left == right);
                }

            }

        }

        ///<summary>
        ///Creation entrypoint for the contract.
        ///This runs exactly once when the application is created. Even though we already gave defaults in __init__, we explicitly set our global counters here to make the initialization logic very obvious.
        ///</summary>
        public async Task Create(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Create_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 76, 92, 97, 186 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Opt-in entrypoint.
        ///Whenever an account opts into this application and calls this method, we initialize its `has_voted` flag to 0 (meaning: they have not voted yet).
        ///</summary>
        public async Task OptIn(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> OptIn_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 48, 198, 213, 138 };

            return await base.MakeTransactionList(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Cast a vote for the given choice.
        ///</summary>
        /// <param name="choice">"yes" or "no" </param>
        public async Task Vote(string choice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 242, 127, 77 };
            var choiceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); choiceAbi.From(choice);

            var result = await base.CallApp(new List<object> { abiHandle, choiceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        public async Task<List<Transaction>> Vote_Transactions(string choice, Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 129, 242, 127, 77 };
            var choiceAbi = new AVM.ClientGenerator.ABI.ARC4.Types.String(); choiceAbi.From(choice);

            return await base.MakeTransactionList(new List<object> { abiHandle, choiceAbi }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);

        }

        ///<summary>
        ///Get the current vote tallies.
        ///</summary>
        public async Task<Structs.VoteTally> GetVotes(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 50, 255, 190 };

            var result = await base.CallApp(new List<object> { abiHandle }, _tx_fee: _tx_fee, _tx_callType: _tx_callType, _tx_roundValidity: _tx_roundValidity, _tx_note: _tx_note, _tx_sender: _tx_sender, _tx_transactions: _tx_transactions, _tx_apps: _tx_apps, _tx_assets: _tx_assets, _tx_accounts: _tx_accounts, _tx_boxes: _tx_boxes);
            var lastLogBytes = result.Last();
            if (lastLogBytes.Length < 4 || lastLogBytes[0] != 21 || lastLogBytes[1] != 31 || lastLogBytes[2] != 124 || lastLogBytes[3] != 117) throw new Exception("Invalid ABI handle");
            return Structs.VoteTally.Parse(lastLogBytes.Skip(4).ToArray());

        }

        public async Task<List<Transaction>> GetVotes_Transactions(Account _tx_sender, ulong? _tx_fee, string _tx_note = "", ulong _tx_roundValidity = 1000, List<BoxRef>? _tx_boxes = null, List<Transaction>? _tx_transactions = null, List<ulong>? _tx_assets = null, List<ulong>? _tx_apps = null, List<Address>? _tx_accounts = null, AVM.ClientGenerator.Core.OnCompleteType _tx_callType = AVM.ClientGenerator.Core.OnCompleteType.NoOp)
        {
            _tx_boxes ??= new List<BoxRef>();
            _tx_transactions ??= new List<Transaction>();
            _tx_assets ??= new List<ulong>();
            _tx_apps ??= new List<ulong>();
            _tx_accounts ??= new List<Address>();
            byte[] abiHandle = { 59, 50, 255, 190 };

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
        protected string _ARC56DATA = "eyJhcmNzIjpbMjIsMjhdLCJuYW1lIjoiVm90aW5nUG9sbCIsImRlc2MiOiJcbiAgICBWb3RpbmdQb2xsIOKAkyBhIG1pbmltYWwsIGJlc3TigJFwcmFjdGljZSBBbGdvcmFuZCBQeXRob24gY29udHJhY3QuXG5cbiAgICBUaGlzIGNvbnRyYWN0IGRlbW9uc3RyYXRlczpcblxuICAgIDEuIEVYUExJQ0lUIFRZUEVTIEVWRVJZV0hFUkVcbiAgICAgICAtIEFsbCBvbi1jaGFpbiBzdGF0ZSB1c2VzIGFsZ29weS5VSW50NjQgLyBhbGdvcHkuU3RyaW5nLFxuICAgICAgICAgbmV2ZXIgYmFyZSBpbnQvc3RyLlxuICAgICAgIC0gTWV0aG9kIHBhcmFtZXRlcnMgYW5kIHJldHVybiB2YWx1ZXMgYXJlIHR5cGVkLlxuXG4gICAgMi4gRkFNSUxJQVIgUFlUSE9OIENPTlNUUlVDVFNcbiAgICAgICAtIFdlIHN0aWxsIHVzZSBfX2luaXRfXywgTmFtZWRUdXBsZSwgaWYvZWxpZi9lbHNlLCBhbmQgYXNzZXJ0LFxuICAgICAgICAgc28gdGhlIGNvZGUgcmVhZHMgbGlrZSBub3JtYWwgUHl0aG9uLlxuXG4gICAgMy4gQVZNIFJFU1RSSUNUSU9OUyBBUkUgUkVTUEVDVEVEXG4gICAgICAgLSBUaGUgQVZNIGRvZXNu4oCZdCBoYXZlIGEgbmF0aXZlIGJvb2wgdHlwZSwgc28gd2UgbW9kZWwgYm9vbGVhbnNcbiAgICAgICAgIGFzIFVJbnQ2NCgwKSBhbmQgVUludDY0KDEpLlxuICAgICAgIC0gV2UgdXNlIGFzc2VydCB0byBoYW5kbGUgaW52YWxpZCBzaXR1YXRpb25zLCB3aGljaCBjb21waWxlc1xuICAgICAgICAgZG93biB0byBhIHNhZmUgQVZNIGVycm9yLlxuXG4gICAgNC4gU1RBVElDIFRZUElORyBQUkVWRU5UUyBFUlJPUlNcbiAgICAgICAtIFdlIGRlY2xhcmUgc3RhdGUgb24gc2VsZiBpbiBfX2luaXRfXywgc28gdGhlIGNvbXBpbGVyIHVuZGVyc3RhbmRzXG4gICAgICAgICBlYWNoIGZpZWxk4oCZcyB0eXBlLlxuICAgICAgIC0gTWlzdXNpbmcgQVBJcyAoZm9yIGV4YW1wbGUsIGNhbGxpbmcgLmdldCgpIG9uIGEgVUludDY0IGluc3RlYWRcbiAgICAgICAgIG9mIGEgTG9jYWxTdGF0ZSkgYmVjb21lcyBhIGNvbXBpbGXigJF0aW1lIGVycm9yIGluc3RlYWQgb2YgYVxuICAgICAgICAgaGlkZGVuIHJ1bnRpbWUgYnVnLlxuICAgICIsIm5ldHdvcmtzIjp7fSwic3RydWN0cyI6eyJWb3RlVGFsbHkiOlt7Im5hbWUiOiJ5ZXMiLCJ0eXBlIjoidWludDY0In0seyJuYW1lIjoibm8iLCJ0eXBlIjoidWludDY0In1dfSwiTWV0aG9kcyI6W3sibmFtZSI6ImNyZWF0ZSIsImRlc2MiOiJDcmVhdGlvbiBlbnRyeXBvaW50IGZvciB0aGUgY29udHJhY3QuXG5UaGlzIHJ1bnMgZXhhY3RseSBvbmNlIHdoZW4gdGhlIGFwcGxpY2F0aW9uIGlzIGNyZWF0ZWQuIEV2ZW4gdGhvdWdoIHdlIGFscmVhZHkgZ2F2ZSBkZWZhdWx0cyBpbiBfX2luaXRfXywgd2UgZXhwbGljaXRseSBzZXQgb3VyIGdsb2JhbCBjb3VudGVycyBoZXJlIHRvIG1ha2UgdGhlIGluaXRpYWxpemF0aW9uIGxvZ2ljIHZlcnkgb2J2aW91cy4iLCJhcmdzIjpbXSwicmV0dXJucyI6eyJ0eXBlIjoidm9pZCIsInN0cnVjdCI6bnVsbCwiZGVzYyI6bnVsbH0sImFjdGlvbnMiOnsiY3JlYXRlIjpbIk5vT3AiXSwiY2FsbCI6W119LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoib3B0X2luIiwiZGVzYyI6Ik9wdC1pbiBlbnRyeXBvaW50LlxuV2hlbmV2ZXIgYW4gYWNjb3VudCBvcHRzIGludG8gdGhpcyBhcHBsaWNhdGlvbiBhbmQgY2FsbHMgdGhpcyBtZXRob2QsIHdlIGluaXRpYWxpemUgaXRzIGBoYXNfdm90ZWRgIGZsYWcgdG8gMCAobWVhbmluZzogdGhleSBoYXZlIG5vdCB2b3RlZCB5ZXQpLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiJ2b2lkIiwic3RydWN0IjpudWxsLCJkZXNjIjpudWxsfSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk9wdEluIl19LCJyZWFkb25seSI6ZmFsc2UsImV2ZW50cyI6W10sInJlY29tbWVuZGF0aW9ucyI6eyJpbm5lclRyYW5zYWN0aW9uQ291bnQiOm51bGwsImJveGVzIjpudWxsLCJhY2NvdW50cyI6bnVsbCwiYXBwcyI6bnVsbCwiYXNzZXRzIjpudWxsfX0seyJuYW1lIjoidm90ZSIsImRlc2MiOiJDYXN0IGEgdm90ZSBmb3IgdGhlIGdpdmVuIGNob2ljZS4iLCJhcmdzIjpbeyJ0eXBlIjoic3RyaW5nIiwic3RydWN0IjpudWxsLCJuYW1lIjoiY2hvaWNlIiwiZGVzYyI6IlwieWVzXCIgb3IgXCJub1wiIiwiZGVmYXVsdFZhbHVlIjpudWxsfV0sInJldHVybnMiOnsidHlwZSI6InZvaWQiLCJzdHJ1Y3QiOm51bGwsImRlc2MiOm51bGx9LCJhY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOlsiTm9PcCJdfSwicmVhZG9ubHkiOmZhbHNlLCJldmVudHMiOltdLCJyZWNvbW1lbmRhdGlvbnMiOnsiaW5uZXJUcmFuc2FjdGlvbkNvdW50IjpudWxsLCJib3hlcyI6bnVsbCwiYWNjb3VudHMiOm51bGwsImFwcHMiOm51bGwsImFzc2V0cyI6bnVsbH19LHsibmFtZSI6ImdldF92b3RlcyIsImRlc2MiOiJHZXQgdGhlIGN1cnJlbnQgdm90ZSB0YWxsaWVzLiIsImFyZ3MiOltdLCJyZXR1cm5zIjp7InR5cGUiOiIodWludDY0LHVpbnQ2NCkiLCJzdHJ1Y3QiOiJWb3RlVGFsbHkiLCJkZXNjIjoiYSBOYW1lZFR1cGxlICh5ZXM6IFVJbnQ2NCwgbm86IFVJbnQ2NCkifSwiYWN0aW9ucyI6eyJjcmVhdGUiOltdLCJjYWxsIjpbIk5vT3AiXX0sInJlYWRvbmx5IjpmYWxzZSwiZXZlbnRzIjpbXSwicmVjb21tZW5kYXRpb25zIjp7ImlubmVyVHJhbnNhY3Rpb25Db3VudCI6bnVsbCwiYm94ZXMiOm51bGwsImFjY291bnRzIjpudWxsLCJhcHBzIjpudWxsLCJhc3NldHMiOm51bGx9fV0sInN0YXRlIjp7InNjaGVtYSI6eyJnbG9iYWwiOnsiaW50cyI6MiwiYnl0ZXMiOjB9LCJsb2NhbCI6eyJpbnRzIjoxLCJieXRlcyI6MH19LCJrZXlzIjp7Imdsb2JhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwia2V5IjoiIn0sImxvY2FsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJrZXkiOiIifX0sIm1hcHMiOnsiZ2xvYmFsIjp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9LCJsb2NhbCI6eyJkZXNjIjpudWxsLCJrZXlUeXBlIjoiIiwidmFsdWVUeXBlIjoiIiwicHJlZml4IjpudWxsfSwiYm94Ijp7ImRlc2MiOm51bGwsImtleVR5cGUiOiIiLCJ2YWx1ZVR5cGUiOiIiLCJwcmVmaXgiOm51bGx9fX0sImJhcmVBY3Rpb25zIjp7ImNyZWF0ZSI6W10sImNhbGwiOltdfSwic291cmNlSW5mbyI6eyJhcHByb3ZhbCI6eyJzb3VyY2VJbmZvIjpbeyJwYyI6WzE5NF0sImVycm9yTWVzc2FnZSI6IkludmFsaWQgY2hvaWNlOiBtdXN0IGJlICd5ZXMnIG9yICdubyciLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOls2M10sImVycm9yTWVzc2FnZSI6Ik9uQ29tcGxldGlvbiBtdXN0IGJlIE5vT3AiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxMTJdLCJlcnJvck1lc3NhZ2UiOiJPbkNvbXBsZXRpb24gbXVzdCBiZSBPcHRJbiAmJiBjYW4gb25seSBjYWxsIHdoZW4gbm90IGNyZWF0aW5nIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTYyXSwiZXJyb3JNZXNzYWdlIjoiWW91IGhhdmUgYWxyZWFkeSB2b3RlZCEiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxOTgsMjE0XSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi5ub192b3RlcyBleGlzdHMiLCJ0ZWFsIjpudWxsLCJzb3VyY2UiOm51bGx9LHsicGMiOlsxNzUsMjEwXSwiZXJyb3JNZXNzYWdlIjoiY2hlY2sgc2VsZi55ZXNfdm90ZXMgZXhpc3RzIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTM2XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBhcnJheSBsZW5ndGggaGVhZGVyIiwidGVhbCI6bnVsbCwic291cmNlIjpudWxsfSx7InBjIjpbMTQ0XSwiZXJyb3JNZXNzYWdlIjoiaW52YWxpZCBudW1iZXIgb2YgYnl0ZXMgZm9yIGFyYzQuZHluYW1pY19hcnJheTxhcmM0LnVpbnQ4PiIsInRlYWwiOm51bGwsInNvdXJjZSI6bnVsbH1dLCJwY09mZnNldE1ldGhvZCI6Im5vbmUifSwiY2xlYXIiOnsic291cmNlSW5mbyI6W10sInBjT2Zmc2V0TWV0aG9kIjoibm9uZSJ9fSwic291cmNlIjp7ImFwcHJvdmFsIjoiSTNCeVlXZHRZU0IyWlhKemFXOXVJREV4Q2lOd2NtRm5iV0VnZEhsd1pYUnlZV05ySUdaaGJITmxDZ292THlCaGJHZHZjSGt1WVhKak5DNUJVa00wUTI5dWRISmhZM1F1WVhCd2NtOTJZV3hmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lHbHVkR05pYkc5amF5QXdJREVLSUNBZ0lHSjVkR1ZqWW14dlkyc2dJbmxsYzE5MmIzUmxjeUlnSW01dlgzWnZkR1Z6SWlBaWFHRnpYM1p2ZEdWa0lnb2dJQ0FnZEhodUlFRndjR3hwWTJGMGFXOXVTVVFLSUNBZ0lHSnVlaUJ0WVdsdVgyRm1kR1Z5WDJsbVgyVnNjMlZBTWdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEdsdVoxOXdiMnhzTDJOdmJuUnlZV04wTG5CNU9qRXhOQW9nSUNBZ0x5OGdhMlY1UFNKNVpYTmZkbTkwWlhNaUxBb2dJQ0FnWW5sMFpXTmZNQ0F2THlBaWVXVnpYM1p2ZEdWeklnb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHbHVaMTl3YjJ4c0wyTnZiblJ5WVdOMExuQjVPakV4TXdvZ0lDQWdMeThnVlVsdWREWTBLREFwTEFvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1JwYm1kZmNHOXNiQzlqYjI1MGNtRmpkQzV3ZVRveE1URXRNVEUyQ2lBZ0lDQXZMeUFqSUZSdmRHRnNJRzUxYldKbGNpQnZaaUFpZVdWeklpQjJiM1JsY3lCaFkzSnZjM01nZEdobElHVnVkR2x5WlNCaGNIQXVDaUFnSUNBdkx5QnpaV3htTG5sbGMxOTJiM1JsY3lBOUlFZHNiMkpoYkZOMFlYUmxLQW9nSUNBZ0x5OGdJQ0FnSUZWSmJuUTJOQ2d3S1N3S0lDQWdJQzh2SUNBZ0lDQnJaWGs5SW5sbGMxOTJiM1JsY3lJc0NpQWdJQ0F2THlBZ0lDQWdaR1Z6WTNKcGNIUnBiMjQ5SWxSdmRHRnNJRzUxYldKbGNpQnZaaUFuZVdWekp5QjJiM1JsY3lCallYTjBJR2x1SUhSb2FYTWdjRzlzYkNJc0NpQWdJQ0F2THlBcENpQWdJQ0JoY0hCZloyeHZZbUZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHbHVaMTl3YjJ4c0wyTnZiblJ5WVdOMExuQjVPakV5TVFvZ0lDQWdMeThnYTJWNVBTSnViMTkyYjNSbGN5SXNDaUFnSUNCaWVYUmxZMTh4SUM4dklDSnViMTkyYjNSbGN5SUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnBibWRmY0c5c2JDOWpiMjUwY21GamRDNXdlVG94TWpBS0lDQWdJQzh2SUZWSmJuUTJOQ2d3S1N3S0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYVc1blgzQnZiR3d2WTI5dWRISmhZM1F1Y0hrNk1URTRMVEV5TXdvZ0lDQWdMeThnSXlCVWIzUmhiQ0J1ZFcxaVpYSWdiMllnSW01dklpQjJiM1JsY3lCaFkzSnZjM01nZEdobElHVnVkR2x5WlNCaGNIQXVDaUFnSUNBdkx5QnpaV3htTG01dlgzWnZkR1Z6SUQwZ1IyeHZZbUZzVTNSaGRHVW9DaUFnSUNBdkx5QWdJQ0FnVlVsdWREWTBLREFwTEFvZ0lDQWdMeThnSUNBZ0lHdGxlVDBpYm05ZmRtOTBaWE1pTEFvZ0lDQWdMeThnSUNBZ0lHUmxjMk55YVhCMGFXOXVQU0pVYjNSaGJDQnVkVzFpWlhJZ2IyWWdKMjV2SnlCMmIzUmxjeUJqWVhOMElHbHVJSFJvYVhNZ2NHOXNiQ0lzQ2lBZ0lDQXZMeUFwQ2lBZ0lDQmhjSEJmWjJ4dlltRnNYM0IxZEFvS2JXRnBibDloWm5SbGNsOXBabDlsYkhObFFESTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBhVzVuWDNCdmJHd3ZZMjl1ZEhKaFkzUXVjSGs2TlRNdE5qUUtJQ0FnSUM4dklDTWdQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOUNpQWdJQ0F2THlBaklDQkRiMjUwY21GamREb2dWbTkwYVc1blVHOXNiQW9nSUNBZ0x5OGdJeUE5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMEtJQ0FnSUM4dklDTWdUbTkzSUhkbElHUmxabWx1WlNCdmRYSWdiV0ZwYmlCamIyNTBjbUZqZEM0Z1ZHaGxJR2R2WVd3Z2FHVnlaU0JwY3lCdWIzUWdkRzhnWW5WcGJHUWdZU0JqYjIxd2JHVjRDaUFnSUNBdkx5QWpJSFp2ZEdsdVp5QnplWE4wWlcwc0lHSjFkQ0IwYnlCemFHOTNJR0VnS20xcGJtbHRZV3dxSUdOdmJuUnlZV04wSUhSb1lYUWdjM1JwYkd3Z1ptOXNiRzkzY3dvZ0lDQWdMeThnSXlCbmIyOWtJSEJoZEhSbGNtNXpPZ29nSUNBZ0x5OGdJd29nSUNBZ0x5OGdJeUFnSUMwZ1YyVWdaR1ZqYkdGeVpTQnpkR0YwWlNCbGVIQnNhV05wZEd4NUlHbHVJRjlmYVc1cGRGOWZDaUFnSUNBdkx5QWpJQ0FnTFNCWFpTQjFjMlVnWTJ4bFlYSWdiV1YwYUc5a0lITnBaMjVoZEhWeVpYTWdkMmwwYUNCMGVYQmxjd29nSUNBZ0x5OGdJeUFnSUMwZ1YyVWdhMlZsY0NCamIyNTBjbTlzSUdac2IzY2dkbVZ5ZVNCUWVYUm9iMjVwWXlBb2FXWXZaV3hwWmk5bGJITmxMQ0JoYzNObGNuUnpLUW9nSUNBZ0x5OGdJeUFnSUMwZ1YyVWdjbVZ6Y0dWamRDQkJWazBnYkdsdGFYUnpJQ2h1YnlCdVlYUnBkbVVnWW05dmJHVmhibk1zSUd4cGJXbDBaV1FnZEhsd1pYTXBDaUFnSUNBdkx5QmpiR0Z6Y3lCV2IzUnBibWRRYjJ4c0tFRlNRelJEYjI1MGNtRmpkQ2s2Q2lBZ0lDQndkWE5vWW5sMFpYTWdNSGd6TUdNMlpEVTRZU0F2THlCdFpYUm9iMlFnSW05d2RGOXBiaWdwZG05cFpDSUtJQ0FnSUhSNGJtRWdRWEJ3YkdsallYUnBiMjVCY21keklEQUtJQ0FnSUcxaGRHTm9JRzFoYVc1ZmIzQjBYMmx1WDNKdmRYUmxRRFFLQ20xaGFXNWZjM2RwZEdOb1gyTmhjMlZmYm1WNGRFQTFPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkR2x1WjE5d2IyeHNMMk52Ym5SeVlXTjBMbkI1T2pVekxUWTBDaUFnSUNBdkx5QWpJRDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBRb2dJQ0FnTHk4Z0l5QWdRMjl1ZEhKaFkzUTZJRlp2ZEdsdVoxQnZiR3dLSUNBZ0lDOHZJQ01nUFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlDaUFnSUNBdkx5QWpJRTV2ZHlCM1pTQmtaV1pwYm1VZ2IzVnlJRzFoYVc0Z1kyOXVkSEpoWTNRdUlGUm9aU0JuYjJGc0lHaGxjbVVnYVhNZ2JtOTBJSFJ2SUdKMWFXeGtJR0VnWTI5dGNHeGxlQW9nSUNBZ0x5OGdJeUIyYjNScGJtY2djM2x6ZEdWdExDQmlkWFFnZEc4Z2MyaHZkeUJoSUNwdGFXNXBiV0ZzS2lCamIyNTBjbUZqZENCMGFHRjBJSE4wYVd4c0lHWnZiR3h2ZDNNS0lDQWdJQzh2SUNNZ1oyOXZaQ0J3WVhSMFpYSnVjem9LSUNBZ0lDOHZJQ01LSUNBZ0lDOHZJQ01nSUNBdElGZGxJR1JsWTJ4aGNtVWdjM1JoZEdVZ1pYaHdiR2xqYVhSc2VTQnBiaUJmWDJsdWFYUmZYd29nSUNBZ0x5OGdJeUFnSUMwZ1YyVWdkWE5sSUdOc1pXRnlJRzFsZEdodlpDQnphV2R1WVhSMWNtVnpJSGRwZEdnZ2RIbHdaWE1LSUNBZ0lDOHZJQ01nSUNBdElGZGxJR3RsWlhBZ1kyOXVkSEp2YkNCbWJHOTNJSFpsY25rZ1VIbDBhRzl1YVdNZ0tHbG1MMlZzYVdZdlpXeHpaU3dnWVhOelpYSjBjeWtLSUNBZ0lDOHZJQ01nSUNBdElGZGxJSEpsYzNCbFkzUWdRVlpOSUd4cGJXbDBjeUFvYm04Z2JtRjBhWFpsSUdKdmIyeGxZVzV6TENCc2FXMXBkR1ZrSUhSNWNHVnpLUW9nSUNBZ0x5OGdZMnhoYzNNZ1ZtOTBhVzVuVUc5c2JDaEJVa00wUTI5dWRISmhZM1FwT2dvZ0lDQWdkSGh1SUU5dVEyOXRjR3hsZEdsdmJnb2dJQ0FnSVFvZ0lDQWdZWE56WlhKMElDOHZJRTl1UTI5dGNHeGxkR2x2YmlCdGRYTjBJR0psSUU1dlQzQUtJQ0FnSUhSNGJpQkJjSEJzYVdOaGRHbHZia2xFQ2lBZ0lDQmllaUJ0WVdsdVgyTnlaV0YwWlY5T2IwOXdRREV3Q2lBZ0lDQndkWE5vWW5sMFpYTnpJREI0T0RGbU1qZG1OR1FnTUhnellqTXlabVppWlNBdkx5QnRaWFJvYjJRZ0luWnZkR1VvYzNSeWFXNW5LWFp2YVdRaUxDQnRaWFJvYjJRZ0ltZGxkRjkyYjNSbGN5Z3BLSFZwYm5RMk5DeDFhVzUwTmpRcElnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dkbTkwWlNCblpYUmZkbTkwWlhNS0lDQWdJR1Z5Y2dvS2JXRnBibDlqY21WaGRHVmZUbTlQY0VBeE1Eb0tJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnBibWRmY0c5c2JDOWpiMjUwY21GamRDNXdlVG8xTXkwMk5Bb2dJQ0FnTHk4Z0l5QTlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwS0lDQWdJQzh2SUNNZ0lFTnZiblJ5WVdOME9pQldiM1JwYm1kUWIyeHNDaUFnSUNBdkx5QWpJRDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBUMDlQVDA5UFQwOVBRb2dJQ0FnTHk4Z0l5Qk9iM2NnZDJVZ1pHVm1hVzVsSUc5MWNpQnRZV2x1SUdOdmJuUnlZV04wTGlCVWFHVWdaMjloYkNCb1pYSmxJR2x6SUc1dmRDQjBieUJpZFdsc1pDQmhJR052YlhCc1pYZ0tJQ0FnSUM4dklDTWdkbTkwYVc1bklITjVjM1JsYlN3Z1luVjBJSFJ2SUhOb2IzY2dZU0FxYldsdWFXMWhiQ29nWTI5dWRISmhZM1FnZEdoaGRDQnpkR2xzYkNCbWIyeHNiM2R6Q2lBZ0lDQXZMeUFqSUdkdmIyUWdjR0YwZEdWeWJuTTZDaUFnSUNBdkx5QWpDaUFnSUNBdkx5QWpJQ0FnTFNCWFpTQmtaV05zWVhKbElITjBZWFJsSUdWNGNHeHBZMmwwYkhrZ2FXNGdYMTlwYm1sMFgxOEtJQ0FnSUM4dklDTWdJQ0F0SUZkbElIVnpaU0JqYkdWaGNpQnRaWFJvYjJRZ2MybG5ibUYwZFhKbGN5QjNhWFJvSUhSNWNHVnpDaUFnSUNBdkx5QWpJQ0FnTFNCWFpTQnJaV1Z3SUdOdmJuUnliMndnWm14dmR5QjJaWEo1SUZCNWRHaHZibWxqSUNocFppOWxiR2xtTDJWc2MyVXNJR0Z6YzJWeWRITXBDaUFnSUNBdkx5QWpJQ0FnTFNCWFpTQnlaWE53WldOMElFRldUU0JzYVcxcGRITWdLRzV2SUc1aGRHbDJaU0JpYjI5c1pXRnVjeXdnYkdsdGFYUmxaQ0IwZVhCbGN5a0tJQ0FnSUM4dklHTnNZWE56SUZadmRHbHVaMUJ2Ykd3b1FWSkRORU52Ym5SeVlXTjBLVG9LSUNBZ0lIQjFjMmhpZVhSbGN5QXdlRFJqTldNMk1XSmhJQzh2SUcxbGRHaHZaQ0FpWTNKbFlYUmxLQ2wyYjJsa0lnb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Bb2dJQ0FnYldGMFkyZ2dZM0psWVhSbENpQWdJQ0JsY25JS0NtMWhhVzVmYjNCMFgybHVYM0p2ZFhSbFFEUTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBhVzVuWDNCdmJHd3ZZMjl1ZEhKaFkzUXVjSGs2TVRjMkxURTROd29nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklDTWdJRTl3ZEMxcGJpQnRaWFJvYjJRZzRvQ1RJR0ZqWTI5MWJuUXRiR1YyWld3Z2FXNXBkR2xoYkdsNllYUnBiMjRLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QWpJRTVsZUhRc0lIZGxJR0ZrWkNCaGJpQnZjSFRpZ0pGcGJpQnRaWFJvYjJRdUlGUm9hWE1nYVhNZ1kyRnNiR1ZrSUhkb1pXNGdZVzRnWVdOamIzVnVkQ0J6Wlc1a2N5QmhiZ29nSUNBZ0x5OGdJeUJCY0hCc2FXTmhkR2x2Yms5d2RFbHVJSFJ5WVc1ellXTjBhVzl1SUhSdklIUm9hWE1nWVhCd0lHRnVaQ0JqYUc5dmMyVnpJSFJvYVhNZ1FVSkpJRzFsZEdodlpDNEtJQ0FnSUM4dklDTUtJQ0FnSUM4dklDTWdWR2hsSUd0bGVTQjBhR2x1WnlCMGJ5QnViM1JwWTJVZ2FYTWdkR2hsSUdSbFkyOXlZWFJ2Y2pvS0lDQWdJQzh2SUNNZ0lDQmhiR3h2ZDE5aFkzUnBiMjV6UFZzaVQzQjBTVzRpWFFvZ0lDQWdMeThnSXdvZ0lDQWdMeThnSXlCVWFHRjBJRzFsWVc1eklIUm9hWE1nWm5WdVkzUnBiMjRnYVhNZ0ttOXViSGtxSUhaaGJHbGtJR1IxY21sdVp5QmhiaUJQY0hSSmJpQjBjbUZ1YzJGamRHbHZiaXdLSUNBZ0lDOHZJQ01nWVc1a0lHbDA0b0NaY3lCbGVHRmpkR3g1SUhkb1pYSmxJSGRsSUhObGRDQjFjQ0IwYUdGMElHRmpZMjkxYm5UaWdKbHpJR3h2WTJGc0lITjBZWFJsTGdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkNoaGJHeHZkMTloWTNScGIyNXpQVnNpVDNCMFNXNGlYU2tLSUNBZ0lIUjRiaUJQYmtOdmJYQnNaWFJwYjI0S0lDQWdJR2x1ZEdOZk1TQXZMeUJQY0hSSmJnb2dJQ0FnUFQwS0lDQWdJSFI0YmlCQmNIQnNhV05oZEdsdmJrbEVDaUFnSUNBbUpnb2dJQ0FnWVhOelpYSjBJQzh2SUU5dVEyOXRjR3hsZEdsdmJpQnRkWE4wSUdKbElFOXdkRWx1SUNZbUlHTmhiaUJ2Ym14NUlHTmhiR3dnZDJobGJpQnViM1FnWTNKbFlYUnBibWNLSUNBZ0lHSWdiM0IwWDJsdUNnb0tMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMblp2ZEdsdVoxOXdiMnhzTG1OdmJuUnlZV04wTGxadmRHbHVaMUJ2Ykd3dVkzSmxZWFJsVzNKdmRYUnBibWRkS0NrZ0xUNGdkbTlwWkRvS1kzSmxZWFJsT2dvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEdsdVoxOXdiMnhzTDJOdmJuUnlZV04wTG5CNU9qRTJOeTB4TmprS0lDQWdJQzh2SUNNZ1JYaHdiR2xqYVhSc2VTQnlaWE5sZENCaWIzUm9JR052ZFc1MFpYSnpJSFJ2SURBdUNpQWdJQ0F2THlBaklFRmpZMlZ6YzJsdVp5QmdMblpoYkhWbFlDQm5hWFpsY3lCMWN5QjBhR1VnZDNKaGNIQmxaQ0JWU1c1ME5qUWdjM1J2Y21Wa0lHbHVJR2RzYjJKaGJDQnpkR0YwWlM0S0lDQWdJQzh2SUhObGJHWXVlV1Z6WDNadmRHVnpMblpoYkhWbElEMGdWVWx1ZERZMEtEQXBDaUFnSUNCaWVYUmxZMTh3SUM4dklDSjVaWE5mZG05MFpYTWlDaUFnSUNCcGJuUmpYekFnTHk4Z01Bb2dJQ0FnWVhCd1gyZHNiMkpoYkY5d2RYUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnBibWRmY0c5c2JDOWpiMjUwY21GamRDNXdlVG94TnpBS0lDQWdJQzh2SUhObGJHWXVibTlmZG05MFpYTXVkbUZzZFdVZ1BTQlZTVzUwTmpRb01Da0tJQ0FnSUdKNWRHVmpYekVnTHk4Z0ltNXZYM1p2ZEdWeklnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5bmJHOWlZV3hmY0hWMENpQWdJQ0F2THlCemJXRnlkRjlqYjI1MGNtRmpkSE12ZG05MGFXNW5YM0J2Ykd3dlkyOXVkSEpoWTNRdWNIazZNVFEyTFRFMU53b2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ0lFTnlaV0YwWlNCdFpYUm9iMlFnNG9DVElHUmxjR3h2ZVMxMGFXMWxJR2x1YVhScFlXeHBlbUYwYVc5dUNpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnSXlCT2IzY2dkMlVnWkdWbWFXNWxJSFJvWlNCamNtVmhkR2x2YmlCdFpYUm9iMlFzSUhkb2FXTm9JR0ZqZEhNZ1lTQmlhWFFnYkdsclpTQmhJR052Ym5OMGNuVmpkRzl5Q2lBZ0lDQXZMeUFqSUdGMElHUmxjR3h2ZVNCMGFXMWxMaUJVYUdVZ1pHVmpiM0poZEc5eUlHQmpjbVZoZEdVOUluSmxjWFZwY21VaVlDQjBaV3hzY3lCQmJHZHZjSGtnZEdoaGRBb2dJQ0FnTHk4Z0l5QjBhR2x6SUcxbGRHaHZaRG9LSUNBZ0lDOHZJQ01LSUNBZ0lDOHZJQ01nSUNBdElHMWhlU0J2Ym14NUlHSmxJR05oYkd4bFpDQmtkWEpwYm1jZ1lYQndJR055WldGMGFXOXVDaUFnSUNBdkx5QWpJQ0FnTFNCaGJtUWdiWFZ6ZENCaVpTQmpZV3hzWldRZ2QyaGxiaUIwYUdVZ1kyOXVkSEpoWTNRZ2FYTWdZM0psWVhSbFpBb2dJQ0FnTHk4Z0l3b2dJQ0FnTHk4Z0l5QlVhR2x6SUdseklIZG9aWEpsSUhkbElIQjFkQ0JoYm5rZ2IyNWw0b0NSZEdsdFpTQnBibWwwYVdGc2FYcGhkR2x2YmlCc2IyZHBZeUJtYjNJZ2RHaGxJR0Z3Y0M0S0lDQWdJQzh2SUVCaFltbHRaWFJvYjJRb1kzSmxZWFJsUFNKeVpYRjFhWEpsSWlrS0lDQWdJR2x1ZEdOZk1TQXZMeUF4Q2lBZ0lDQnlaWFIxY200S0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkbTkwYVc1blgzQnZiR3d1WTI5dWRISmhZM1F1Vm05MGFXNW5VRzlzYkM1dmNIUmZhVzViY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwdmNIUmZhVzQ2Q2lBZ0lDQXZMeUJ6YldGeWRGOWpiMjUwY21GamRITXZkbTkwYVc1blgzQnZiR3d2WTI5dWRISmhZM1F1Y0hrNk1UazNMVEU1T0FvZ0lDQWdMeThnSXlCVWVHNHVjMlZ1WkdWeUlHbHpJSFJvWlNCaFkyTnZkVzUwSUhSb1lYUWdhWE1nWTNWeWNtVnVkR3g1SUc5d2RHbHVaeUJwYmk0S0lDQWdJQzh2SUhObGJtUmxjaUE5SUZSNGJpNXpaVzVrWlhJS0lDQWdJSFI0YmlCVFpXNWtaWElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1JwYm1kZmNHOXNiQzlqYjI1MGNtRmpkQzV3ZVRveU1EQXRNakEwQ2lBZ0lDQXZMeUFqSUVobGNtVWdkMlVnZDNKcGRHVWdkRzhnVEc5allXeFRkR0YwWlNCMWMybHVaeUJoY25KaGVlS0FrV3hwYTJVZ2MzbHVkR0Y0T2dvZ0lDQWdMeThnSXlBZ0lITmxiR1l1YUdGelgzWnZkR1ZrVzJGalkyOTFiblJkSUQwZ2RtRnNkV1VLSUNBZ0lDOHZJQ01LSUNBZ0lDOHZJQ01nVkdocGN5QmhiR3h2WTJGMFpYTWdiM0lnYzJWMGN5QjBhR0YwSUhCbGN1S0FrV0ZqWTI5MWJuUWdhMlY1SUdadmNpQjBhR1VnYzJWdVpHVnlMZ29nSUNBZ0x5OGdjMlZzWmk1b1lYTmZkbTkwWldSYmMyVnVaR1Z5WFNBOUlGVkpiblEyTkNnd0tRb2dJQ0FnWW5sMFpXTmZNaUF2THlBaWFHRnpYM1p2ZEdWa0lnb2dJQ0FnYVc1MFkxOHdJQzh2SURBS0lDQWdJR0Z3Y0Y5c2IyTmhiRjl3ZFhRS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNScGJtZGZjRzlzYkM5amIyNTBjbUZqZEM1d2VUb3hOell0TVRnM0NpQWdJQ0F2THlBaklDMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFFvZ0lDQWdMeThnSXlBZ1QzQjBMV2x1SUcxbGRHaHZaQ0RpZ0pNZ1lXTmpiM1Z1ZEMxc1pYWmxiQ0JwYm1sMGFXRnNhWHBoZEdsdmJnb2dJQ0FnTHk4Z0l5QXRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1RtVjRkQ3dnZDJVZ1lXUmtJR0Z1SUc5d2RPS0FrV2x1SUcxbGRHaHZaQzRnVkdocGN5QnBjeUJqWVd4c1pXUWdkMmhsYmlCaGJpQmhZMk52ZFc1MElITmxibVJ6SUdGdUNpQWdJQ0F2THlBaklFRndjR3hwWTJGMGFXOXVUM0IwU1c0Z2RISmhibk5oWTNScGIyNGdkRzhnZEdocGN5QmhjSEFnWVc1a0lHTm9iMjl6WlhNZ2RHaHBjeUJCUWtrZ2JXVjBhRzlrTGdvZ0lDQWdMeThnSXdvZ0lDQWdMeThnSXlCVWFHVWdhMlY1SUhSb2FXNW5JSFJ2SUc1dmRHbGpaU0JwY3lCMGFHVWdaR1ZqYjNKaGRHOXlPZ29nSUNBZ0x5OGdJeUFnSUdGc2JHOTNYMkZqZEdsdmJuTTlXeUpQY0hSSmJpSmRDaUFnSUNBdkx5QWpDaUFnSUNBdkx5QWpJRlJvWVhRZ2JXVmhibk1nZEdocGN5Qm1kVzVqZEdsdmJpQnBjeUFxYjI1c2VTb2dkbUZzYVdRZ1pIVnlhVzVuSUdGdUlFOXdkRWx1SUhSeVlXNXpZV04wYVc5dUxBb2dJQ0FnTHk4Z0l5QmhibVFnYVhUaWdKbHpJR1Y0WVdOMGJIa2dkMmhsY21VZ2QyVWdjMlYwSUhWd0lIUm9ZWFFnWVdOamIzVnVkT0tBbVhNZ2JHOWpZV3dnYzNSaGRHVXVDaUFnSUNBdkx5QkFZV0pwYldWMGFHOWtLR0ZzYkc5M1gyRmpkR2x2Ym5NOVd5SlBjSFJKYmlKZEtRb2dJQ0FnYVc1MFkxOHhJQzh2SURFS0lDQWdJSEpsZEhWeWJnb0tDaTh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTUyYjNScGJtZGZjRzlzYkM1amIyNTBjbUZqZEM1V2IzUnBibWRRYjJ4c0xuWnZkR1ZiY205MWRHbHVaMTBvS1NBdFBpQjJiMmxrT2dwMmIzUmxPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkR2x1WjE5d2IyeHNMMk52Ym5SeVlXTjBMbkI1T2pJd05pMHlNVE1LSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRDaUFnSUNBdkx5QWpJQ0IyYjNSbElPS0FreUJ0WVdsdUlHeHZaMmxqQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdJeUJPYjNjZ2QyVWdZMjl0WlNCMGJ5QjBhR1VnYldGcGJpQmlkWE5wYm1WemN5QnNiMmRwWXpvZ1kyRnpkR2x1WnlCaElIWnZkR1V1Q2lBZ0lDQXZMeUFqQ2lBZ0lDQXZMeUFqSUU1dmRHbGpaU0JvYjNjZ2QyVWdkWE5sSUdGdUlHVjRjR3hwWTJsMElGTjBjbWx1WnlCMGVYQmxJR1p2Y2lCMGFHVWdZMmh2YVdObElIQmhjbUZ0WlhSbGNpNEtJQ0FnSUM4dklDTWdWR2hwY3lCcGN5QmhibTkwYUdWeUlHVjRZVzF3YkdVZ2IyWWc0b0NjZFhObElHVjRjR3hwWTJsMElIUjVjR1Z6SUdadmNpQndZWEpoYldWMFpYSnpJR0Z1WkNCeVpYUjFjbTV6NG9DZExnb2dJQ0FnTHk4Z1FHRmlhVzFsZEdodlpBb2dJQ0FnZEhodVlTQkJjSEJzYVdOaGRHbHZia0Z5WjNNZ01Rb2dJQ0FnWkhWd0NpQWdJQ0JwYm5Salh6QWdMeThnTUFvZ0lDQWdaWGgwY21GamRGOTFhVzUwTVRZZ0x5OGdiMjRnWlhKeWIzSTZJR2x1ZG1Gc2FXUWdZWEp5WVhrZ2JHVnVaM1JvSUdobFlXUmxjZ29nSUNBZ2NIVnphR2x1ZENBeUlDOHZJRElLSUNBZ0lDc0tJQ0FnSUdScFp5QXhDaUFnSUNCc1pXNEtJQ0FnSUQwOUNpQWdJQ0JoYzNObGNuUWdMeThnYVc1MllXeHBaQ0J1ZFcxaVpYSWdiMllnWW5sMFpYTWdabTl5SUdGeVl6UXVaSGx1WVcxcFkxOWhjbkpoZVR4aGNtTTBMblZwYm5RNFBnb2dJQ0FnWlhoMGNtRmpkQ0F5SURBS0lDQWdJR1IxY0FvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEdsdVoxOXdiMnhzTDJOdmJuUnlZV04wTG5CNU9qSXlOeTB5TXpFS0lDQWdJQzh2SUNNZ0xTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklDTWdNU2tnUTJobFkyc2dabTl5SUdSdmRXSnNaUzEyYjNScGJtY2dLRXh2WTJGc1UzUmhkR1VwQ2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlBaklFWnBjbk4wSUhkbElISmxZV1FnZDJodklHbHpJR05oYkd4cGJtY2dkR2hwY3lCdFpYUm9iMlF1Q2lBZ0lDQXZMeUJ6Wlc1a1pYSWdQU0JVZUc0dWMyVnVaR1Z5Q2lBZ0lDQjBlRzRnVTJWdVpHVnlDaUFnSUNCa2RYQUtJQ0FnSUdOdmRtVnlJRElLSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1JwYm1kZmNHOXNiQzlqYjI1MGNtRmpkQzV3ZVRveU16TXRNak00Q2lBZ0lDQXZMeUFqSUZSb1pXNGdkMlVnYkc5dmF5QjFjQ0IwYUdWcGNpQnNiMk5oYkNCZ2FHRnpYM1p2ZEdWa1lDQnpkR0YwZFhNdUNpQWdJQ0F2THlBakNpQWdJQ0F2THlBaklGZGxJSFZ6WlNCMGFHVWdZQzVuWlhRb1lXTmpiM1Z1ZEN3Z1pHVm1ZWFZzZEY5MllXeDFaU2xnSUdadmNtMGdkRzhnYUdGdVpHeGxJSFJvWlNCallYTmxDaUFnSUNBdkx5QWpJSGRvWlhKbElIUm9aU0JoWTJOdmRXNTBJR2hoYzI3aWdKbDBJSE4wYjNKbFpDQmhibmwwYUdsdVp5QjVaWFF1SUVsbUlIUm9aU0JyWlhrZ1pHOWxjeUJ1YjNRS0lDQWdJQzh2SUNNZ1pYaHBjM1FzSUhSb2FYTWdjbVYwZFhKdWN5QlZTVzUwTmpRb01Da3NJSGRvYVdOb0lIZGxJR2x1ZEdWeWNISmxkQ0JoY3lEaWdKeHViM1FnZG05MFpXVGlnSjB1Q2lBZ0lDQXZMeUJvWVhOZmRtOTBaV1JmYzNSaGRIVnpJRDBnYzJWc1ppNW9ZWE5mZG05MFpXUXVaMlYwS0hObGJtUmxjaXdnVlVsdWREWTBLREFwS1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpJZ0x5OGdJbWhoYzE5MmIzUmxaQ0lLSUNBZ0lHRndjRjlzYjJOaGJGOW5aWFJmWlhnS0lDQWdJR2x1ZEdOZk1DQXZMeUF3Q2lBZ0lDQmpiM1psY2lBeUNpQWdJQ0J6Wld4bFkzUUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnBibWRmY0c5c2JDOWpiMjUwY21GamRDNXdlVG95TkRBdE1qUTFDaUFnSUNBdkx5QWpJRWhsY21VZ2FYTWdkMmhsY21VZ2QyVWdaVzVtYjNKalpTRGlnSnh2Ym1VZ2NHVnljMjl1TENCdmJtVWdkbTkwWmVLQW5TNEtJQ0FnSUM4dklDTUtJQ0FnSUM4dklDTWdTV1lnYUdGelgzWnZkR1ZrWDNOMFlYUjFjeUJwY3lCdWIzUWdNQ3dnZDJVZ2NtVnFaV04wSUhSb1pTQjBjbUZ1YzJGamRHbHZiaTRnVjJVZ2RYTmxDaUFnSUNBdkx5QWpJR0JoYzNObGNuUmdJSGRwZEdnZ1lTQmpiR1ZoY2lCbGNuSnZjaUJ0WlhOellXZGxMQ0JoYm1RZ1FXeG5iM0I1SUhkcGJHd2dkSFZ5YmlCMGFHbHpDaUFnSUNBdkx5QWpJR2x1ZEc4Z1lTQnpZV1psSUVGV1RTQmxjbkp2Y2lCcFppQjBhR1VnWTI5dVpHbDBhVzl1SUdaaGFXeHpMZ29nSUNBZ0x5OGdZWE56WlhKMElHaGhjMTkyYjNSbFpGOXpkR0YwZFhNZ1BUMGdWVWx1ZERZMEtEQXBMQ0FpV1c5MUlHaGhkbVVnWVd4eVpXRmtlU0IyYjNSbFpDRWlDaUFnSUNBaENpQWdJQ0JoYzNObGNuUWdMeThnV1c5MUlHaGhkbVVnWVd4eVpXRmtlU0IyYjNSbFpDRUtJQ0FnSUM4dklITnRZWEowWDJOdmJuUnlZV04wY3k5MmIzUnBibWRmY0c5c2JDOWpiMjUwY21GamRDNXdlVG95TkRjdE1qVTNDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0Q2lBZ0lDQXZMeUFqSURJcElGVndaR0YwWlNCMGFHVWdaMnh2WW1Gc0lIWnZkR1VnWTI5MWJuUmxjbk1LSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ1RtVjRkQ0IzWlNCamFHVmpheUIzYUdGMElIUm9aU0IxYzJWeUlIWnZkR1ZrSUdadmNpNGdWR2hsSUc1cFkyVWdkR2hwYm1jZ2FYTWdkR2hoZENCM1pRb2dJQ0FnTHk4Z0l5QmpZVzRnYzNScGJHd2dkM0pwZEdVZ2JtOXliV0ZzSUZCNWRHaHZiaUJwWmk5bGJHbG1MMlZzYzJVZ2FHVnlaU3dnWVc1a0lFRnNaMjl3ZVNCM2FXeHNDaUFnSUNBdkx5QWpJR052YlhCcGJHVWdhWFFnWkc5M2JpQjBieUJCVmswZ2FXNXpkSEoxWTNScGIyNXpMZ29nSUNBZ0x5OGdJd29nSUNBZ0x5OGdJeUJYWlNCamIyMXdZWEpsSUhSb1pTQmphRzlwWTJVZ1lXZGhhVzV6ZENCemRISnBibWNnYkdsMFpYSmhiSE1nSW5sbGN5SWdZVzVrSUNKdWJ5SXVDaUFnSUNBdkx5QWpJRlJvWlNCQlVrUGlnSkUwSUhKdmRYUmxjaUJvWVc1a2JHVnpJR1Z1WTI5a2FXNW5JR0Z1WkNCa1pXTnZaR2x1WnlCMGFHVWdVM1J5YVc1bklIUjVjR1VLSUNBZ0lDOHZJQ01nWm05eUlIVnpJSFZ1WkdWeUlIUm9aU0JvYjI5a0xnb2dJQ0FnTHk4Z2FXWWdZMmh2YVdObElEMDlJQ0o1WlhNaU9nb2dJQ0FnY0hWemFHSjVkR1Z6SUNKNVpYTWlDaUFnSUNBOVBRb2dJQ0FnWW5vZ2RtOTBaVjlsYkhObFgySnZaSGxBTXdvZ0lDQWdMeThnYzIxaGNuUmZZMjl1ZEhKaFkzUnpMM1p2ZEdsdVoxOXdiMnhzTDJOdmJuUnlZV04wTG5CNU9qSTFPQzB5TlRrS0lDQWdJQzh2SUNNZ1NXNWpjbVZ0Wlc1MElIUm9aU0I1WlhNZ1kyOTFiblJsY2lCaWVTQXhMZ29nSUNBZ0x5OGdjMlZzWmk1NVpYTmZkbTkwWlhNdWRtRnNkV1VnUFNCelpXeG1MbmxsYzE5MmIzUmxjeTUyWVd4MVpTQXJJRlZKYm5RMk5DZ3hLUW9nSUNBZ2FXNTBZMTh3SUM4dklEQUtJQ0FnSUdKNWRHVmpYekFnTHk4Z0lubGxjMTkyYjNSbGN5SUtJQ0FnSUdGd2NGOW5iRzlpWVd4ZloyVjBYMlY0Q2lBZ0lDQmhjM05sY25RZ0x5OGdZMmhsWTJzZ2MyVnNaaTU1WlhOZmRtOTBaWE1nWlhocGMzUnpDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnS3dvZ0lDQWdZbmwwWldOZk1DQXZMeUFpZVdWelgzWnZkR1Z6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0NuWnZkR1ZmWVdaMFpYSmZhV1pmWld4elpVQTNPZ29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkR2x1WjE5d2IyeHNMMk52Ym5SeVlXTjBMbkI1T2pJM01DMHlOelVLSUNBZ0lDOHZJQ01nTFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwS0lDQWdJQzh2SUNNZ015a2dUV0Z5YXlCMGFHVWdZMkZzYkdWeUlHRnpJR2hoZG1sdVp5QjJiM1JsWkFvZ0lDQWdMeThnSXlBdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z0l5QkdhVzVoYkd4NUxDQjNaU0JtYkdsd0lIUm9aU0JqWVd4c1pYTGlnSmx6SUdCb1lYTmZkbTkwWldSZ0lHWnNZV2NnZEc4Z01TQW9iV1ZoYm1sdVp5QlVjblZsS1M0S0lDQWdJQzh2SUNNZ1ZHaHBjeUIxYzJWeklIUm9aU0J6WVcxbElFeHZZMkZzVTNSaGRHVWdhVzVrWlhocGJtY2djM2x1ZEdGNElHRnpJR2x1SUc5d2RGOXBiaWdwTGdvZ0lDQWdMeThnYzJWc1ppNW9ZWE5mZG05MFpXUmJjMlZ1WkdWeVhTQTlJRlZKYm5RMk5DZ3hLUW9nSUNBZ1pIVndDaUFnSUNCaWVYUmxZMTh5SUM4dklDSm9ZWE5mZG05MFpXUWlDaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnWVhCd1gyeHZZMkZzWDNCMWRBb2dJQ0FnTHk4Z2MyMWhjblJmWTI5dWRISmhZM1J6TDNadmRHbHVaMTl3YjJ4c0wyTnZiblJ5WVdOMExuQjVPakl3TmkweU1UTUtJQ0FnSUM4dklDTWdMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdENpQWdJQ0F2THlBaklDQjJiM1JsSU9LQWt5QnRZV2x1SUd4dloybGpDaUFnSUNBdkx5QWpJQzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExRb2dJQ0FnTHk4Z0l5Qk9iM2NnZDJVZ1kyOXRaU0IwYnlCMGFHVWdiV0ZwYmlCaWRYTnBibVZ6Y3lCc2IyZHBZem9nWTJGemRHbHVaeUJoSUhadmRHVXVDaUFnSUNBdkx5QWpDaUFnSUNBdkx5QWpJRTV2ZEdsalpTQm9iM2NnZDJVZ2RYTmxJR0Z1SUdWNGNHeHBZMmwwSUZOMGNtbHVaeUIwZVhCbElHWnZjaUIwYUdVZ1kyaHZhV05sSUhCaGNtRnRaWFJsY2k0S0lDQWdJQzh2SUNNZ1ZHaHBjeUJwY3lCaGJtOTBhR1Z5SUdWNFlXMXdiR1VnYjJZZzRvQ2NkWE5sSUdWNGNHeHBZMmwwSUhSNWNHVnpJR1p2Y2lCd1lYSmhiV1YwWlhKeklHRnVaQ0J5WlhSMWNtNXo0b0NkTGdvZ0lDQWdMeThnUUdGaWFXMWxkR2h2WkFvZ0lDQWdhVzUwWTE4eElDOHZJREVLSUNBZ0lISmxkSFZ5YmdvS2RtOTBaVjlsYkhObFgySnZaSGxBTXpvS0lDQWdJQzh2SUhOdFlYSjBYMk52Ym5SeVlXTjBjeTkyYjNScGJtZGZjRzlzYkM5amIyNTBjbUZqZEM1d2VUb3lOakVLSUNBZ0lDOHZJR1ZzYVdZZ1kyaHZhV05sSUQwOUlDSnVieUk2Q2lBZ0lDQmthV2NnTVFvZ0lDQWdjSFZ6YUdKNWRHVnpJQ0p1YnlJS0lDQWdJRDA5Q2lBZ0lDQmhjM05sY25RZ0x5OGdTVzUyWVd4cFpDQmphRzlwWTJVNklHMTFjM1FnWW1VZ0ozbGxjeWNnYjNJZ0oyNXZKd29nSUNBZ0x5OGdjMjFoY25SZlkyOXVkSEpoWTNSekwzWnZkR2x1WjE5d2IyeHNMMk52Ym5SeVlXTjBMbkI1T2pJMk1pMHlOak1LSUNBZ0lDOHZJQ01nU1c1amNtVnRaVzUwSUhSb1pTQnVieUJqYjNWdWRHVnlJR0o1SURFdUNpQWdJQ0F2THlCelpXeG1MbTV2WDNadmRHVnpMblpoYkhWbElEMGdjMlZzWmk1dWIxOTJiM1JsY3k1MllXeDFaU0FySUZWSmJuUTJOQ2d4S1FvZ0lDQWdhVzUwWTE4d0lDOHZJREFLSUNBZ0lHSjVkR1ZqWHpFZ0x5OGdJbTV2WDNadmRHVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG01dlgzWnZkR1Z6SUdWNGFYTjBjd29nSUNBZ2FXNTBZMTh4SUM4dklERUtJQ0FnSUNzS0lDQWdJR0o1ZEdWalh6RWdMeThnSW01dlgzWnZkR1Z6SWdvZ0lDQWdjM2RoY0FvZ0lDQWdZWEJ3WDJkc2IySmhiRjl3ZFhRS0lDQWdJR0lnZG05MFpWOWhablJsY2w5cFpsOWxiSE5sUURjS0Nnb3ZMeUJ6YldGeWRGOWpiMjUwY21GamRITXVkbTkwYVc1blgzQnZiR3d1WTI5dWRISmhZM1F1Vm05MGFXNW5VRzlzYkM1blpYUmZkbTkwWlhOYmNtOTFkR2x1WjEwb0tTQXRQaUIyYjJsa09ncG5aWFJmZG05MFpYTTZDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBhVzVuWDNCdmJHd3ZZMjl1ZEhKaFkzUXVjSGs2TWprNUNpQWdJQ0F2THlCNVpYTTljMlZzWmk1NVpYTmZkbTkwWlhNdWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTUNBdkx5QWllV1Z6WDNadmRHVnpJZ29nSUNBZ1lYQndYMmRzYjJKaGJGOW5aWFJmWlhnS0lDQWdJR0Z6YzJWeWRDQXZMeUJqYUdWamF5QnpaV3htTG5sbGMxOTJiM1JsY3lCbGVHbHpkSE1LSUNBZ0lDOHZJSE50WVhKMFgyTnZiblJ5WVdOMGN5OTJiM1JwYm1kZmNHOXNiQzlqYjI1MGNtRmpkQzV3ZVRvek1EQUtJQ0FnSUM4dklHNXZQWE5sYkdZdWJtOWZkbTkwWlhNdWRtRnNkV1VzQ2lBZ0lDQnBiblJqWHpBZ0x5OGdNQW9nSUNBZ1lubDBaV05mTVNBdkx5QWlibTlmZG05MFpYTWlDaUFnSUNCaGNIQmZaMnh2WW1Gc1gyZGxkRjlsZUFvZ0lDQWdZWE56WlhKMElDOHZJR05vWldOcklITmxiR1l1Ym05ZmRtOTBaWE1nWlhocGMzUnpDaUFnSUNBdkx5QnpiV0Z5ZEY5amIyNTBjbUZqZEhNdmRtOTBhVzVuWDNCdmJHd3ZZMjl1ZEhKaFkzUXVjSGs2TWpnd0xUSTROZ29nSUNBZ0x5OGdJeUF0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMEtJQ0FnSUM4dklDTWdJR2RsZEY5MmIzUmxjeURpZ0pNZ2NtVmhaQzF2Ym14NUlIRjFaWEo1Q2lBZ0lDQXZMeUFqSUMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUzB0TFMwdExTMHRMUW9nSUNBZ0x5OGdJeUJVYnlCamIyMXdiR1YwWlNCMGFHVWdaWGhoYlhCc1pTd2dkMlVnWVdSa0lHRWdjMjFoYkd3Z2NtVmhaT0tBa1c5dWJIa2diV1YwYUc5a0lIUm9ZWFFnY21WMGRYSnVjd29nSUNBZ0x5OGdJeUIwYUdVZ1kzVnljbVZ1ZENCMmIzUmxJSFJoYkd4cFpYTXVJRlJvYVhNZ2FYTWdZU0J1YVdObElIZGhlU0IwYnlCemFHOTNJR2h2ZHlCMGJ5QjFjMlVnWVFvZ0lDQWdMeThnSXlCT1lXMWxaRlIxY0d4bElHRnpJR0VnY21WMGRYSnVJSFI1Y0dVZ2FXNGdRVkpENG9DUk5DNEtJQ0FnSUM4dklFQmhZbWx0WlhSb2IyUUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUhOM1lYQUtJQ0FnSUdsMGIySUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2NIVnphR0o1ZEdWeklEQjRNVFV4Wmpkak56VUtJQ0FnSUhOM1lYQUtJQ0FnSUdOdmJtTmhkQW9nSUNBZ2JHOW5DaUFnSUNCcGJuUmpYekVnTHk4Z01Rb2dJQ0FnY21WMGRYSnVDZz09IiwiY2xlYXIiOiJJM0J5WVdkdFlTQjJaWEp6YVc5dUlERXhDaU53Y21GbmJXRWdkSGx3WlhSeVlXTnJJR1poYkhObENnb3ZMeUJoYkdkdmNIa3VZWEpqTkM1QlVrTTBRMjl1ZEhKaFkzUXVZMnhsWVhKZmMzUmhkR1ZmY0hKdlozSmhiU2dwSUMwK0lIVnBiblEyTkRvS2JXRnBiam9LSUNBZ0lIQjFjMmhwYm5RZ01TQXZMeUF4Q2lBZ0lDQnlaWFIxY200SyJ9LCJieXRlQ29kZSI6eyJhcHByb3ZhbCI6IkN5QUNBQUVtQXdsNVpYTmZkbTkwWlhNSWJtOWZkbTkwWlhNSmFHRnpYM1p2ZEdWa01SaEFBQVlvSW1jcEltZUFCRERHMVlvMkdnQ09BUUF0TVJrVVJERVlRUUFXZ2dJRWdmSi9UUVE3TXYrK05ob0FqZ0lBS1FCMUFJQUVURnhodWpZYUFJNEJBQXdBTVJrakVqRVlFRVJDQUFnb0ltY3BJbWNqUXpFQUtpSm1JME0yR2dGSklsbUJBZ2hMQVJVU1JGY0NBRWt4QUVsT0FpSXFZeUpPQWswVVJJQURlV1Z6RWtFQUR5SW9aVVFqQ0NoTVowa3FJMllqUTBzQmdBSnVieEpFSWlsbFJDTUlLVXhuUXYvbUlpaGxSQ0lwWlVSTUZrd1dVSUFFRlI5OGRVeFFzQ05EIiwiY2xlYXIiOiJDNEVCUXc9PSJ9LCJjb21waWxlckluZm8iOnsiY29tcGlsZXIiOiJwdXlhIiwiY29tcGlsZXJWZXJzaW9uIjp7Im1ham9yIjo1LCJtaW5vciI6NCwicGF0Y2giOjAsImNvbW1pdEhhc2giOm51bGx9fSwiZXZlbnRzIjpbXSwidGVtcGxhdGVWYXJpYWJsZXMiOnt9LCJzY3JhdGNoVmFyaWFibGVzIjp7fX0=";
    }

}
