// $ANTLR 3.3 Nov 30, 2010 12:50:56 NCalc.g 2013-08-30 12:41:20

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System;
using System.Text;
using System.Globalization;
using System.Collections.Generic;
using NCalc.Domain;


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;


using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class NCalcParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "INTEGER", "FLOAT", "STRING", "DATETIME", "TRUE", "FALSE", "ID", "NAME", "LETTER", "DIGIT", "E", "EscapeSequence", "UnicodeEscape", "HexDigit", "WS", "'?'", "':'", "'||'", "'or'", "'&&'", "'and'", "'|'", "'^'", "'&'", "'=='", "'='", "'!='", "'<>'", "'<'", "'<='", "'>'", "'>='", "'<<'", "'>>'", "'+'", "'-'", "'*'", "'/'", "'%'", "'!'", "'not'", "'~'", "'('", "')'", "','"
	};
	public const int EOF=-1;
	public const int T__19=19;
	public const int T__20=20;
	public const int T__21=21;
	public const int T__22=22;
	public const int T__23=23;
	public const int T__24=24;
	public const int T__25=25;
	public const int T__26=26;
	public const int T__27=27;
	public const int T__28=28;
	public const int T__29=29;
	public const int T__30=30;
	public const int T__31=31;
	public const int T__32=32;
	public const int T__33=33;
	public const int T__34=34;
	public const int T__35=35;
	public const int T__36=36;
	public const int T__37=37;
	public const int T__38=38;
	public const int T__39=39;
	public const int T__40=40;
	public const int T__41=41;
	public const int T__42=42;
	public const int T__43=43;
	public const int T__44=44;
	public const int T__45=45;
	public const int T__46=46;
	public const int T__47=47;
	public const int T__48=48;
	public const int INTEGER=4;
	public const int FLOAT=5;
	public const int STRING=6;
	public const int DATETIME=7;
	public const int TRUE=8;
	public const int FALSE=9;
	public const int ID=10;
	public const int NAME=11;
	public const int LETTER=12;
	public const int DIGIT=13;
	public const int E=14;
	public const int EscapeSequence=15;
	public const int UnicodeEscape=16;
	public const int HexDigit=17;
	public const int WS=18;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false, false, false, false, false, false, false, false, 
				false, false, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public NCalcParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public NCalcParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return NCalcParser.tokenNames; } }
	public override string GrammarFileName { get { return "NCalc.g"; } }


	private const char BS = '\\';
	private static NumberFormatInfo numberFormatInfo = new NumberFormatInfo();

	private string extractString(string text) {
	    
	    StringBuilder sb = new StringBuilder(text);
	    int startIndex = 1; // Skip initial quote
	    int slashIndex = -1;

	    while ((slashIndex = sb.ToString().IndexOf(BS, startIndex)) != -1)
	    {
	        char escapeType = sb[slashIndex + 1];
	        switch (escapeType)
	        {
	            case 'u':
	              string hcode = String.Concat(sb[slashIndex+4], sb[slashIndex+5]);
	              string lcode = String.Concat(sb[slashIndex+2], sb[slashIndex+3]);
	              char unicodeChar = Encoding.Unicode.GetChars(new byte[] { System.Convert.ToByte(hcode, 16), System.Convert.ToByte(lcode, 16)} )[0];
	              sb.Remove(slashIndex, 6).Insert(slashIndex, unicodeChar); 
	              break;
	            case 'n': sb.Remove(slashIndex, 2).Insert(slashIndex, '\n'); break;
	            case 'r': sb.Remove(slashIndex, 2).Insert(slashIndex, '\r'); break;
	            case 't': sb.Remove(slashIndex, 2).Insert(slashIndex, '\t'); break;
	            case '\'': sb.Remove(slashIndex, 2).Insert(slashIndex, '\''); break;
	            case '\\': sb.Remove(slashIndex, 2).Insert(slashIndex, '\\'); break;
	            default: throw new RecognitionException("Unvalid escape sequence: \\" + escapeType);
	        }

	        startIndex = slashIndex + 1;

	    }

	    sb.Remove(0, 1);
	    sb.Remove(sb.Length - 1, 1);

	    return sb.ToString();
	}

	public List<string> Errors { get; private set; }

	public override void DisplayRecognitionError(String[] tokenNames, RecognitionException e) {
	    
	    base.DisplayRecognitionError(tokenNames, e);
	    
	    if(Errors == null)
	    {
	    	Errors = new List<string>();
	    }
	    
	    String hdr = GetErrorHeader(e);
	    String msg = GetErrorMessage(e, tokenNames);
	    Errors.Add(msg + " at " + hdr);
	}


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class ncalcExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public LogicalExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_ncalcExpression();
	partial void Leave_ncalcExpression();

	// $ANTLR start "ncalcExpression"
	// NCalc.g:77:1: ncalcExpression returns [LogicalExpression value] : logicalExpression EOF ;
	[GrammarRule("ncalcExpression")]
	internal NCalcParser.ncalcExpression_return ncalcExpression()
	{
		Enter_ncalcExpression();
		EnterRule("ncalcExpression", 1);
		TraceIn("ncalcExpression", 1);
		NCalcParser.ncalcExpression_return retval = new NCalcParser.ncalcExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken EOF2=null;
		NCalcParser.logicalExpression_return logicalExpression1 = default(NCalcParser.logicalExpression_return);

		object EOF2_tree=null;

		try { DebugEnterRule(GrammarFileName, "ncalcExpression");
		DebugLocation(77, 1);
		try
		{
			// NCalc.g:78:2: ( logicalExpression EOF )
			DebugEnterAlt(1);
			// NCalc.g:78:4: logicalExpression EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(78, 4);
			PushFollow(Follow._logicalExpression_in_ncalcExpression50);
			logicalExpression1=logicalExpression();
			PopFollow();

			adaptor.AddChild(root_0, logicalExpression1.Tree);
			DebugLocation(78, 25);
			EOF2=(IToken)Match(input,EOF,Follow._EOF_in_ncalcExpression52); 
			DebugLocation(78, 27);
			retval.value = (logicalExpression1!=null?logicalExpression1.value:default(LogicalExpression)); 

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("ncalcExpression", 1);
			LeaveRule("ncalcExpression", 1);
			Leave_ncalcExpression();
		}
		DebugLocation(79, 1);
		} finally { DebugExitRule(GrammarFileName, "ncalcExpression"); }
		return retval;

	}
	// $ANTLR end "ncalcExpression"

	public class logicalExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public LogicalExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_logicalExpression();
	partial void Leave_logicalExpression();

	// $ANTLR start "logicalExpression"
	// NCalc.g:81:1: logicalExpression returns [LogicalExpression value] : left= conditionalExpression ( '?' middle= conditionalExpression ':' right= conditionalExpression )? ;
	[GrammarRule("logicalExpression")]
	private NCalcParser.logicalExpression_return logicalExpression()
	{
		Enter_logicalExpression();
		EnterRule("logicalExpression", 2);
		TraceIn("logicalExpression", 2);
		NCalcParser.logicalExpression_return retval = new NCalcParser.logicalExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal3=null;
		IToken char_literal4=null;
		NCalcParser.conditionalExpression_return left = default(NCalcParser.conditionalExpression_return);
		NCalcParser.conditionalExpression_return middle = default(NCalcParser.conditionalExpression_return);
		NCalcParser.conditionalExpression_return right = default(NCalcParser.conditionalExpression_return);

		object char_literal3_tree=null;
		object char_literal4_tree=null;

		try { DebugEnterRule(GrammarFileName, "logicalExpression");
		DebugLocation(81, 1);
		try
		{
			// NCalc.g:82:2: (left= conditionalExpression ( '?' middle= conditionalExpression ':' right= conditionalExpression )? )
			DebugEnterAlt(1);
			// NCalc.g:82:4: left= conditionalExpression ( '?' middle= conditionalExpression ':' right= conditionalExpression )?
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(82, 8);
			PushFollow(Follow._conditionalExpression_in_logicalExpression72);
			left=conditionalExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(82, 31);
			 retval.value = (left!=null?left.value:default(LogicalExpression)); 
			DebugLocation(82, 57);
			// NCalc.g:82:57: ( '?' middle= conditionalExpression ':' right= conditionalExpression )?
			int alt1=2;
			try { DebugEnterSubRule(1);
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			int LA1_0 = input.LA(1);

			if ((LA1_0==19))
			{
				alt1=1;
			}
			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:82:59: '?' middle= conditionalExpression ':' right= conditionalExpression
				{
				DebugLocation(82, 59);
				char_literal3=(IToken)Match(input,19,Follow._19_in_logicalExpression78); 
				char_literal3_tree = (object)adaptor.Create(char_literal3);
				adaptor.AddChild(root_0, char_literal3_tree);

				DebugLocation(82, 69);
				PushFollow(Follow._conditionalExpression_in_logicalExpression82);
				middle=conditionalExpression();
				PopFollow();

				adaptor.AddChild(root_0, middle.Tree);
				DebugLocation(82, 92);
				char_literal4=(IToken)Match(input,20,Follow._20_in_logicalExpression84); 
				char_literal4_tree = (object)adaptor.Create(char_literal4);
				adaptor.AddChild(root_0, char_literal4_tree);

				DebugLocation(82, 101);
				PushFollow(Follow._conditionalExpression_in_logicalExpression88);
				right=conditionalExpression();
				PopFollow();

				adaptor.AddChild(root_0, right.Tree);
				DebugLocation(82, 124);
				 retval.value = new TernaryExpression((left!=null?left.value:default(LogicalExpression)), (middle!=null?middle.value:default(LogicalExpression)), (right!=null?right.value:default(LogicalExpression))); 

				}
				break;

			}
			} finally { DebugExitSubRule(1); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("logicalExpression", 2);
			LeaveRule("logicalExpression", 2);
			Leave_logicalExpression();
		}
		DebugLocation(83, 1);
		} finally { DebugExitRule(GrammarFileName, "logicalExpression"); }
		return retval;

	}
	// $ANTLR end "logicalExpression"

	public class conditionalExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public LogicalExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_conditionalExpression();
	partial void Leave_conditionalExpression();

	// $ANTLR start "conditionalExpression"
	// NCalc.g:85:1: conditionalExpression returns [LogicalExpression value] : left= booleanAndExpression ( ( '||' | 'or' ) right= conditionalExpression )* ;
	[GrammarRule("conditionalExpression")]
	private NCalcParser.conditionalExpression_return conditionalExpression()
	{
		Enter_conditionalExpression();
		EnterRule("conditionalExpression", 3);
		TraceIn("conditionalExpression", 3);
		NCalcParser.conditionalExpression_return retval = new NCalcParser.conditionalExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set5=null;
		NCalcParser.booleanAndExpression_return left = default(NCalcParser.booleanAndExpression_return);
		NCalcParser.conditionalExpression_return right = default(NCalcParser.conditionalExpression_return);

		object set5_tree=null;


		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "conditionalExpression");
		DebugLocation(85, 1);
		try
		{
			// NCalc.g:89:2: (left= booleanAndExpression ( ( '||' | 'or' ) right= conditionalExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:89:4: left= booleanAndExpression ( ( '||' | 'or' ) right= conditionalExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(89, 8);
			PushFollow(Follow._booleanAndExpression_in_conditionalExpression115);
			left=booleanAndExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(89, 30);
			 retval.value = (left!=null?left.value:default(LogicalExpression)); 
			DebugLocation(89, 56);
			// NCalc.g:89:56: ( ( '||' | 'or' ) right= conditionalExpression )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if (((LA2_0>=21 && LA2_0<=22)))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:90:4: ( '||' | 'or' ) right= conditionalExpression
					{
					DebugLocation(90, 4);
					set5=(IToken)input.LT(1);
					if ((input.LA(1)>=21 && input.LA(1)<=22))
					{
						input.Consume();
						adaptor.AddChild(root_0, (object)adaptor.Create(set5));
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(90, 18);
					 type = BinaryExpressionType.Or; 
					DebugLocation(91, 9);
					PushFollow(Follow._conditionalExpression_in_conditionalExpression140);
					right=conditionalExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(91, 32);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?right.value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("conditionalExpression", 3);
			LeaveRule("conditionalExpression", 3);
			Leave_conditionalExpression();
		}
		DebugLocation(93, 1);
		} finally { DebugExitRule(GrammarFileName, "conditionalExpression"); }
		return retval;

	}
	// $ANTLR end "conditionalExpression"

	public class booleanAndExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public LogicalExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_booleanAndExpression();
	partial void Leave_booleanAndExpression();

	// $ANTLR start "booleanAndExpression"
	// NCalc.g:95:1: booleanAndExpression returns [LogicalExpression value] : left= bitwiseOrExpression ( ( '&&' | 'and' ) right= bitwiseOrExpression )* ;
	[GrammarRule("booleanAndExpression")]
	private NCalcParser.booleanAndExpression_return booleanAndExpression()
	{
		Enter_booleanAndExpression();
		EnterRule("booleanAndExpression", 4);
		TraceIn("booleanAndExpression", 4);
		NCalcParser.booleanAndExpression_return retval = new NCalcParser.booleanAndExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set6=null;
		NCalcParser.bitwiseOrExpression_return left = default(NCalcParser.bitwiseOrExpression_return);
		NCalcParser.bitwiseOrExpression_return right = default(NCalcParser.bitwiseOrExpression_return);

		object set6_tree=null;


		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "booleanAndExpression");
		DebugLocation(95, 1);
		try
		{
			// NCalc.g:99:2: (left= bitwiseOrExpression ( ( '&&' | 'and' ) right= bitwiseOrExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:99:4: left= bitwiseOrExpression ( ( '&&' | 'and' ) right= bitwiseOrExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(99, 8);
			PushFollow(Follow._bitwiseOrExpression_in_booleanAndExpression174);
			left=bitwiseOrExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(99, 29);
			 retval.value = (left!=null?left.value:default(LogicalExpression)); 
			DebugLocation(99, 55);
			// NCalc.g:99:55: ( ( '&&' | 'and' ) right= bitwiseOrExpression )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, decisionCanBacktrack[3]);
				int LA3_0 = input.LA(1);

				if (((LA3_0>=23 && LA3_0<=24)))
				{
					alt3=1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:100:4: ( '&&' | 'and' ) right= bitwiseOrExpression
					{
					DebugLocation(100, 4);
					set6=(IToken)input.LT(1);
					if ((input.LA(1)>=23 && input.LA(1)<=24))
					{
						input.Consume();
						adaptor.AddChild(root_0, (object)adaptor.Create(set6));
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(100, 19);
					 type = BinaryExpressionType.And; 
					DebugLocation(101, 9);
					PushFollow(Follow._bitwiseOrExpression_in_booleanAndExpression199);
					right=bitwiseOrExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(101, 30);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?right.value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("booleanAndExpression", 4);
			LeaveRule("booleanAndExpression", 4);
			Leave_booleanAndExpression();
		}
		DebugLocation(103, 1);
		} finally { DebugExitRule(GrammarFileName, "booleanAndExpression"); }
		return retval;

	}
	// $ANTLR end "booleanAndExpression"

	public class bitwiseOrExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public LogicalExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bitwiseOrExpression();
	partial void Leave_bitwiseOrExpression();

	// $ANTLR start "bitwiseOrExpression"
	// NCalc.g:105:1: bitwiseOrExpression returns [LogicalExpression value] : left= bitwiseXOrExpression ( '|' right= bitwiseOrExpression )* ;
	[GrammarRule("bitwiseOrExpression")]
	private NCalcParser.bitwiseOrExpression_return bitwiseOrExpression()
	{
		Enter_bitwiseOrExpression();
		EnterRule("bitwiseOrExpression", 5);
		TraceIn("bitwiseOrExpression", 5);
		NCalcParser.bitwiseOrExpression_return retval = new NCalcParser.bitwiseOrExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal7=null;
		NCalcParser.bitwiseXOrExpression_return left = default(NCalcParser.bitwiseXOrExpression_return);
		NCalcParser.bitwiseOrExpression_return right = default(NCalcParser.bitwiseOrExpression_return);

		object char_literal7_tree=null;


		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "bitwiseOrExpression");
		DebugLocation(105, 1);
		try
		{
			// NCalc.g:109:2: (left= bitwiseXOrExpression ( '|' right= bitwiseOrExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:109:4: left= bitwiseXOrExpression ( '|' right= bitwiseOrExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(109, 8);
			PushFollow(Follow._bitwiseXOrExpression_in_bitwiseOrExpression231);
			left=bitwiseXOrExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(109, 30);
			 retval.value = (left!=null?left.value:default(LogicalExpression)); 
			DebugLocation(109, 56);
			// NCalc.g:109:56: ( '|' right= bitwiseOrExpression )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0==25))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:110:4: '|' right= bitwiseOrExpression
					{
					DebugLocation(110, 4);
					char_literal7=(IToken)Match(input,25,Follow._25_in_bitwiseOrExpression240); 
					char_literal7_tree = (object)adaptor.Create(char_literal7);
					adaptor.AddChild(root_0, char_literal7_tree);

					DebugLocation(110, 8);
					 type = BinaryExpressionType.BitwiseOr; 
					DebugLocation(111, 9);
					PushFollow(Follow._bitwiseOrExpression_in_bitwiseOrExpression250);
					right=bitwiseOrExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(111, 30);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?right.value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bitwiseOrExpression", 5);
			LeaveRule("bitwiseOrExpression", 5);
			Leave_bitwiseOrExpression();
		}
		DebugLocation(113, 1);
		} finally { DebugExitRule(GrammarFileName, "bitwiseOrExpression"); }
		return retval;

	}
	// $ANTLR end "bitwiseOrExpression"

	public class bitwiseXOrExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public LogicalExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bitwiseXOrExpression();
	partial void Leave_bitwiseXOrExpression();

	// $ANTLR start "bitwiseXOrExpression"
	// NCalc.g:115:1: bitwiseXOrExpression returns [LogicalExpression value] : left= bitwiseAndExpression ( '^' right= bitwiseAndExpression )* ;
	[GrammarRule("bitwiseXOrExpression")]
	private NCalcParser.bitwiseXOrExpression_return bitwiseXOrExpression()
	{
		Enter_bitwiseXOrExpression();
		EnterRule("bitwiseXOrExpression", 6);
		TraceIn("bitwiseXOrExpression", 6);
		NCalcParser.bitwiseXOrExpression_return retval = new NCalcParser.bitwiseXOrExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal8=null;
		NCalcParser.bitwiseAndExpression_return left = default(NCalcParser.bitwiseAndExpression_return);
		NCalcParser.bitwiseAndExpression_return right = default(NCalcParser.bitwiseAndExpression_return);

		object char_literal8_tree=null;


		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "bitwiseXOrExpression");
		DebugLocation(115, 1);
		try
		{
			// NCalc.g:119:2: (left= bitwiseAndExpression ( '^' right= bitwiseAndExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:119:4: left= bitwiseAndExpression ( '^' right= bitwiseAndExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(119, 8);
			PushFollow(Follow._bitwiseAndExpression_in_bitwiseXOrExpression284);
			left=bitwiseAndExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(119, 30);
			 retval.value = (left!=null?left.value:default(LogicalExpression)); 
			DebugLocation(119, 56);
			// NCalc.g:119:56: ( '^' right= bitwiseAndExpression )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if ((LA5_0==26))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:120:4: '^' right= bitwiseAndExpression
					{
					DebugLocation(120, 4);
					char_literal8=(IToken)Match(input,26,Follow._26_in_bitwiseXOrExpression293); 
					char_literal8_tree = (object)adaptor.Create(char_literal8);
					adaptor.AddChild(root_0, char_literal8_tree);

					DebugLocation(120, 8);
					 type = BinaryExpressionType.BitwiseXOr; 
					DebugLocation(121, 9);
					PushFollow(Follow._bitwiseAndExpression_in_bitwiseXOrExpression303);
					right=bitwiseAndExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(121, 31);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?right.value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bitwiseXOrExpression", 6);
			LeaveRule("bitwiseXOrExpression", 6);
			Leave_bitwiseXOrExpression();
		}
		DebugLocation(123, 1);
		} finally { DebugExitRule(GrammarFileName, "bitwiseXOrExpression"); }
		return retval;

	}
	// $ANTLR end "bitwiseXOrExpression"

	public class bitwiseAndExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public LogicalExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_bitwiseAndExpression();
	partial void Leave_bitwiseAndExpression();

	// $ANTLR start "bitwiseAndExpression"
	// NCalc.g:125:1: bitwiseAndExpression returns [LogicalExpression value] : left= equalityExpression ( '&' right= equalityExpression )* ;
	[GrammarRule("bitwiseAndExpression")]
	private NCalcParser.bitwiseAndExpression_return bitwiseAndExpression()
	{
		Enter_bitwiseAndExpression();
		EnterRule("bitwiseAndExpression", 7);
		TraceIn("bitwiseAndExpression", 7);
		NCalcParser.bitwiseAndExpression_return retval = new NCalcParser.bitwiseAndExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal9=null;
		NCalcParser.equalityExpression_return left = default(NCalcParser.equalityExpression_return);
		NCalcParser.equalityExpression_return right = default(NCalcParser.equalityExpression_return);

		object char_literal9_tree=null;


		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "bitwiseAndExpression");
		DebugLocation(125, 1);
		try
		{
			// NCalc.g:129:2: (left= equalityExpression ( '&' right= equalityExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:129:4: left= equalityExpression ( '&' right= equalityExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(129, 8);
			PushFollow(Follow._equalityExpression_in_bitwiseAndExpression335);
			left=equalityExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(129, 28);
			 retval.value = (left!=null?left.value:default(LogicalExpression)); 
			DebugLocation(129, 54);
			// NCalc.g:129:54: ( '&' right= equalityExpression )*
			try { DebugEnterSubRule(6);
			while (true)
			{
				int alt6=2;
				try { DebugEnterDecision(6, decisionCanBacktrack[6]);
				int LA6_0 = input.LA(1);

				if ((LA6_0==27))
				{
					alt6=1;
				}


				} finally { DebugExitDecision(6); }
				switch ( alt6 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:130:4: '&' right= equalityExpression
					{
					DebugLocation(130, 4);
					char_literal9=(IToken)Match(input,27,Follow._27_in_bitwiseAndExpression344); 
					char_literal9_tree = (object)adaptor.Create(char_literal9);
					adaptor.AddChild(root_0, char_literal9_tree);

					DebugLocation(130, 8);
					 type = BinaryExpressionType.BitwiseAnd; 
					DebugLocation(131, 9);
					PushFollow(Follow._equalityExpression_in_bitwiseAndExpression354);
					right=equalityExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(131, 29);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?right.value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop6;
				}
			}

			loop6:
				;

			} finally { DebugExitSubRule(6); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("bitwiseAndExpression", 7);
			LeaveRule("bitwiseAndExpression", 7);
			Leave_bitwiseAndExpression();
		}
		DebugLocation(133, 1);
		} finally { DebugExitRule(GrammarFileName, "bitwiseAndExpression"); }
		return retval;

	}
	// $ANTLR end "bitwiseAndExpression"

	public class equalityExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public LogicalExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_equalityExpression();
	partial void Leave_equalityExpression();

	// $ANTLR start "equalityExpression"
	// NCalc.g:135:1: equalityExpression returns [LogicalExpression value] : left= relationalExpression ( ( ( '==' | '=' ) | ( '!=' | '<>' ) ) right= relationalExpression )* ;
	[GrammarRule("equalityExpression")]
	private NCalcParser.equalityExpression_return equalityExpression()
	{
		Enter_equalityExpression();
		EnterRule("equalityExpression", 8);
		TraceIn("equalityExpression", 8);
		NCalcParser.equalityExpression_return retval = new NCalcParser.equalityExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set10=null;
		IToken set11=null;
		NCalcParser.relationalExpression_return left = default(NCalcParser.relationalExpression_return);
		NCalcParser.relationalExpression_return right = default(NCalcParser.relationalExpression_return);

		object set10_tree=null;
		object set11_tree=null;


		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "equalityExpression");
		DebugLocation(135, 1);
		try
		{
			// NCalc.g:139:2: (left= relationalExpression ( ( ( '==' | '=' ) | ( '!=' | '<>' ) ) right= relationalExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:139:4: left= relationalExpression ( ( ( '==' | '=' ) | ( '!=' | '<>' ) ) right= relationalExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(139, 8);
			PushFollow(Follow._relationalExpression_in_equalityExpression388);
			left=relationalExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(139, 30);
			 retval.value = (left!=null?left.value:default(LogicalExpression)); 
			DebugLocation(139, 56);
			// NCalc.g:139:56: ( ( ( '==' | '=' ) | ( '!=' | '<>' ) ) right= relationalExpression )*
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=2;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				int LA8_0 = input.LA(1);

				if (((LA8_0>=28 && LA8_0<=31)))
				{
					alt8=1;
				}


				} finally { DebugExitDecision(8); }
				switch ( alt8 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:140:4: ( ( '==' | '=' ) | ( '!=' | '<>' ) ) right= relationalExpression
					{
					DebugLocation(140, 4);
					// NCalc.g:140:4: ( ( '==' | '=' ) | ( '!=' | '<>' ) )
					int alt7=2;
					try { DebugEnterSubRule(7);
					try { DebugEnterDecision(7, decisionCanBacktrack[7]);
					int LA7_0 = input.LA(1);

					if (((LA7_0>=28 && LA7_0<=29)))
					{
						alt7=1;
					}
					else if (((LA7_0>=30 && LA7_0<=31)))
					{
						alt7=2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(7); }
					switch (alt7)
					{
					case 1:
						DebugEnterAlt(1);
						// NCalc.g:140:6: ( '==' | '=' )
						{
						DebugLocation(140, 6);
						set10=(IToken)input.LT(1);
						if ((input.LA(1)>=28 && input.LA(1)<=29))
						{
							input.Consume();
							adaptor.AddChild(root_0, (object)adaptor.Create(set10));
							state.errorRecovery=false;
						}
						else
						{
							MismatchedSetException mse = new MismatchedSetException(null,input);
							DebugRecognitionException(mse);
							throw mse;
						}

						DebugLocation(140, 20);
						 type = BinaryExpressionType.Equal; 

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// NCalc.g:141:6: ( '!=' | '<>' )
						{
						DebugLocation(141, 6);
						set11=(IToken)input.LT(1);
						if ((input.LA(1)>=30 && input.LA(1)<=31))
						{
							input.Consume();
							adaptor.AddChild(root_0, (object)adaptor.Create(set11));
							state.errorRecovery=false;
						}
						else
						{
							MismatchedSetException mse = new MismatchedSetException(null,input);
							DebugRecognitionException(mse);
							throw mse;
						}

						DebugLocation(141, 21);
						 type = BinaryExpressionType.NotEqual; 

						}
						break;

					}
					} finally { DebugExitSubRule(7); }

					DebugLocation(142, 9);
					PushFollow(Follow._relationalExpression_in_equalityExpression435);
					right=relationalExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(142, 31);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?right.value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop8;
				}
			}

			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("equalityExpression", 8);
			LeaveRule("equalityExpression", 8);
			Leave_equalityExpression();
		}
		DebugLocation(144, 1);
		} finally { DebugExitRule(GrammarFileName, "equalityExpression"); }
		return retval;

	}
	// $ANTLR end "equalityExpression"

	public class relationalExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public LogicalExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_relationalExpression();
	partial void Leave_relationalExpression();

	// $ANTLR start "relationalExpression"
	// NCalc.g:146:1: relationalExpression returns [LogicalExpression value] : left= shiftExpression ( ( '<' | '<=' | '>' | '>=' ) right= shiftExpression )* ;
	[GrammarRule("relationalExpression")]
	private NCalcParser.relationalExpression_return relationalExpression()
	{
		Enter_relationalExpression();
		EnterRule("relationalExpression", 9);
		TraceIn("relationalExpression", 9);
		NCalcParser.relationalExpression_return retval = new NCalcParser.relationalExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal12=null;
		IToken string_literal13=null;
		IToken char_literal14=null;
		IToken string_literal15=null;
		NCalcParser.shiftExpression_return left = default(NCalcParser.shiftExpression_return);
		NCalcParser.shiftExpression_return right = default(NCalcParser.shiftExpression_return);

		object char_literal12_tree=null;
		object string_literal13_tree=null;
		object char_literal14_tree=null;
		object string_literal15_tree=null;


		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "relationalExpression");
		DebugLocation(146, 1);
		try
		{
			// NCalc.g:150:2: (left= shiftExpression ( ( '<' | '<=' | '>' | '>=' ) right= shiftExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:150:4: left= shiftExpression ( ( '<' | '<=' | '>' | '>=' ) right= shiftExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(150, 8);
			PushFollow(Follow._shiftExpression_in_relationalExpression468);
			left=shiftExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(150, 25);
			 retval.value = (left!=null?left.value:default(LogicalExpression)); 
			DebugLocation(150, 51);
			// NCalc.g:150:51: ( ( '<' | '<=' | '>' | '>=' ) right= shiftExpression )*
			try { DebugEnterSubRule(10);
			while (true)
			{
				int alt10=2;
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if (((LA10_0>=32 && LA10_0<=35)))
				{
					alt10=1;
				}


				} finally { DebugExitDecision(10); }
				switch ( alt10 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:151:4: ( '<' | '<=' | '>' | '>=' ) right= shiftExpression
					{
					DebugLocation(151, 4);
					// NCalc.g:151:4: ( '<' | '<=' | '>' | '>=' )
					int alt9=4;
					try { DebugEnterSubRule(9);
					try { DebugEnterDecision(9, decisionCanBacktrack[9]);
					switch (input.LA(1))
					{
					case 32:
						{
						alt9=1;
						}
						break;
					case 33:
						{
						alt9=2;
						}
						break;
					case 34:
						{
						alt9=3;
						}
						break;
					case 35:
						{
						alt9=4;
						}
						break;
					default:
						{
							NoViableAltException nvae = new NoViableAltException("", 9, 0, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}

					} finally { DebugExitDecision(9); }
					switch (alt9)
					{
					case 1:
						DebugEnterAlt(1);
						// NCalc.g:151:6: '<'
						{
						DebugLocation(151, 6);
						char_literal12=(IToken)Match(input,32,Follow._32_in_relationalExpression479); 
						char_literal12_tree = (object)adaptor.Create(char_literal12);
						adaptor.AddChild(root_0, char_literal12_tree);

						DebugLocation(151, 10);
						 type = BinaryExpressionType.Lesser; 

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// NCalc.g:152:6: '<='
						{
						DebugLocation(152, 6);
						string_literal13=(IToken)Match(input,33,Follow._33_in_relationalExpression489); 
						string_literal13_tree = (object)adaptor.Create(string_literal13);
						adaptor.AddChild(root_0, string_literal13_tree);

						DebugLocation(152, 11);
						 type = BinaryExpressionType.LesserOrEqual; 

						}
						break;
					case 3:
						DebugEnterAlt(3);
						// NCalc.g:153:6: '>'
						{
						DebugLocation(153, 6);
						char_literal14=(IToken)Match(input,34,Follow._34_in_relationalExpression500); 
						char_literal14_tree = (object)adaptor.Create(char_literal14);
						adaptor.AddChild(root_0, char_literal14_tree);

						DebugLocation(153, 10);
						 type = BinaryExpressionType.Greater; 

						}
						break;
					case 4:
						DebugEnterAlt(4);
						// NCalc.g:154:6: '>='
						{
						DebugLocation(154, 6);
						string_literal15=(IToken)Match(input,35,Follow._35_in_relationalExpression510); 
						string_literal15_tree = (object)adaptor.Create(string_literal15);
						adaptor.AddChild(root_0, string_literal15_tree);

						DebugLocation(154, 11);
						 type = BinaryExpressionType.GreaterOrEqual; 

						}
						break;

					}
					} finally { DebugExitSubRule(9); }

					DebugLocation(155, 9);
					PushFollow(Follow._shiftExpression_in_relationalExpression522);
					right=shiftExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(155, 26);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?right.value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop10;
				}
			}

			loop10:
				;

			} finally { DebugExitSubRule(10); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("relationalExpression", 9);
			LeaveRule("relationalExpression", 9);
			Leave_relationalExpression();
		}
		DebugLocation(157, 1);
		} finally { DebugExitRule(GrammarFileName, "relationalExpression"); }
		return retval;

	}
	// $ANTLR end "relationalExpression"

	public class shiftExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public LogicalExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_shiftExpression();
	partial void Leave_shiftExpression();

	// $ANTLR start "shiftExpression"
	// NCalc.g:159:1: shiftExpression returns [LogicalExpression value] : left= additiveExpression ( ( '<<' | '>>' ) right= additiveExpression )* ;
	[GrammarRule("shiftExpression")]
	private NCalcParser.shiftExpression_return shiftExpression()
	{
		Enter_shiftExpression();
		EnterRule("shiftExpression", 10);
		TraceIn("shiftExpression", 10);
		NCalcParser.shiftExpression_return retval = new NCalcParser.shiftExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken string_literal16=null;
		IToken string_literal17=null;
		NCalcParser.additiveExpression_return left = default(NCalcParser.additiveExpression_return);
		NCalcParser.additiveExpression_return right = default(NCalcParser.additiveExpression_return);

		object string_literal16_tree=null;
		object string_literal17_tree=null;


		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "shiftExpression");
		DebugLocation(159, 1);
		try
		{
			// NCalc.g:163:2: (left= additiveExpression ( ( '<<' | '>>' ) right= additiveExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:163:4: left= additiveExpression ( ( '<<' | '>>' ) right= additiveExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(163, 8);
			PushFollow(Follow._additiveExpression_in_shiftExpression554);
			left=additiveExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(163, 28);
			 retval.value = (left!=null?left.value:default(LogicalExpression)); 
			DebugLocation(163, 54);
			// NCalc.g:163:54: ( ( '<<' | '>>' ) right= additiveExpression )*
			try { DebugEnterSubRule(12);
			while (true)
			{
				int alt12=2;
				try { DebugEnterDecision(12, decisionCanBacktrack[12]);
				int LA12_0 = input.LA(1);

				if (((LA12_0>=36 && LA12_0<=37)))
				{
					alt12=1;
				}


				} finally { DebugExitDecision(12); }
				switch ( alt12 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:164:4: ( '<<' | '>>' ) right= additiveExpression
					{
					DebugLocation(164, 4);
					// NCalc.g:164:4: ( '<<' | '>>' )
					int alt11=2;
					try { DebugEnterSubRule(11);
					try { DebugEnterDecision(11, decisionCanBacktrack[11]);
					int LA11_0 = input.LA(1);

					if ((LA11_0==36))
					{
						alt11=1;
					}
					else if ((LA11_0==37))
					{
						alt11=2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 11, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(11); }
					switch (alt11)
					{
					case 1:
						DebugEnterAlt(1);
						// NCalc.g:164:6: '<<'
						{
						DebugLocation(164, 6);
						string_literal16=(IToken)Match(input,36,Follow._36_in_shiftExpression565); 
						string_literal16_tree = (object)adaptor.Create(string_literal16);
						adaptor.AddChild(root_0, string_literal16_tree);

						DebugLocation(164, 11);
						 type = BinaryExpressionType.LeftShift; 

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// NCalc.g:165:6: '>>'
						{
						DebugLocation(165, 6);
						string_literal17=(IToken)Match(input,37,Follow._37_in_shiftExpression575); 
						string_literal17_tree = (object)adaptor.Create(string_literal17);
						adaptor.AddChild(root_0, string_literal17_tree);

						DebugLocation(165, 11);
						 type = BinaryExpressionType.RightShift; 

						}
						break;

					}
					} finally { DebugExitSubRule(11); }

					DebugLocation(166, 9);
					PushFollow(Follow._additiveExpression_in_shiftExpression587);
					right=additiveExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(166, 29);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?right.value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop12;
				}
			}

			loop12:
				;

			} finally { DebugExitSubRule(12); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("shiftExpression", 10);
			LeaveRule("shiftExpression", 10);
			Leave_shiftExpression();
		}
		DebugLocation(168, 1);
		} finally { DebugExitRule(GrammarFileName, "shiftExpression"); }
		return retval;

	}
	// $ANTLR end "shiftExpression"

	public class additiveExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public LogicalExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_additiveExpression();
	partial void Leave_additiveExpression();

	// $ANTLR start "additiveExpression"
	// NCalc.g:170:1: additiveExpression returns [LogicalExpression value] : left= multiplicativeExpression ( ( '+' | '-' ) right= multiplicativeExpression )* ;
	[GrammarRule("additiveExpression")]
	private NCalcParser.additiveExpression_return additiveExpression()
	{
		Enter_additiveExpression();
		EnterRule("additiveExpression", 11);
		TraceIn("additiveExpression", 11);
		NCalcParser.additiveExpression_return retval = new NCalcParser.additiveExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal18=null;
		IToken char_literal19=null;
		NCalcParser.multiplicativeExpression_return left = default(NCalcParser.multiplicativeExpression_return);
		NCalcParser.multiplicativeExpression_return right = default(NCalcParser.multiplicativeExpression_return);

		object char_literal18_tree=null;
		object char_literal19_tree=null;


		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "additiveExpression");
		DebugLocation(170, 1);
		try
		{
			// NCalc.g:174:2: (left= multiplicativeExpression ( ( '+' | '-' ) right= multiplicativeExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:174:4: left= multiplicativeExpression ( ( '+' | '-' ) right= multiplicativeExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(174, 8);
			PushFollow(Follow._multiplicativeExpression_in_additiveExpression619);
			left=multiplicativeExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(174, 34);
			 retval.value = (left!=null?left.value:default(LogicalExpression)); 
			DebugLocation(174, 60);
			// NCalc.g:174:60: ( ( '+' | '-' ) right= multiplicativeExpression )*
			try { DebugEnterSubRule(14);
			while (true)
			{
				int alt14=2;
				try { DebugEnterDecision(14, decisionCanBacktrack[14]);
				int LA14_0 = input.LA(1);

				if (((LA14_0>=38 && LA14_0<=39)))
				{
					alt14=1;
				}


				} finally { DebugExitDecision(14); }
				switch ( alt14 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:175:4: ( '+' | '-' ) right= multiplicativeExpression
					{
					DebugLocation(175, 4);
					// NCalc.g:175:4: ( '+' | '-' )
					int alt13=2;
					try { DebugEnterSubRule(13);
					try { DebugEnterDecision(13, decisionCanBacktrack[13]);
					int LA13_0 = input.LA(1);

					if ((LA13_0==38))
					{
						alt13=1;
					}
					else if ((LA13_0==39))
					{
						alt13=2;
					}
					else
					{
						NoViableAltException nvae = new NoViableAltException("", 13, 0, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					} finally { DebugExitDecision(13); }
					switch (alt13)
					{
					case 1:
						DebugEnterAlt(1);
						// NCalc.g:175:6: '+'
						{
						DebugLocation(175, 6);
						char_literal18=(IToken)Match(input,38,Follow._38_in_additiveExpression630); 
						char_literal18_tree = (object)adaptor.Create(char_literal18);
						adaptor.AddChild(root_0, char_literal18_tree);

						DebugLocation(175, 10);
						 type = BinaryExpressionType.Plus; 

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// NCalc.g:176:6: '-'
						{
						DebugLocation(176, 6);
						char_literal19=(IToken)Match(input,39,Follow._39_in_additiveExpression640); 
						char_literal19_tree = (object)adaptor.Create(char_literal19);
						adaptor.AddChild(root_0, char_literal19_tree);

						DebugLocation(176, 10);
						 type = BinaryExpressionType.Minus; 

						}
						break;

					}
					} finally { DebugExitSubRule(13); }

					DebugLocation(177, 9);
					PushFollow(Follow._multiplicativeExpression_in_additiveExpression652);
					right=multiplicativeExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(177, 35);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?right.value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop14;
				}
			}

			loop14:
				;

			} finally { DebugExitSubRule(14); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("additiveExpression", 11);
			LeaveRule("additiveExpression", 11);
			Leave_additiveExpression();
		}
		DebugLocation(179, 1);
		} finally { DebugExitRule(GrammarFileName, "additiveExpression"); }
		return retval;

	}
	// $ANTLR end "additiveExpression"

	public class multiplicativeExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public LogicalExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_multiplicativeExpression();
	partial void Leave_multiplicativeExpression();

	// $ANTLR start "multiplicativeExpression"
	// NCalc.g:181:1: multiplicativeExpression returns [LogicalExpression value] : left= unaryExpression ( ( '*' | '/' | '%' ) right= unaryExpression )* ;
	[GrammarRule("multiplicativeExpression")]
	private NCalcParser.multiplicativeExpression_return multiplicativeExpression()
	{
		Enter_multiplicativeExpression();
		EnterRule("multiplicativeExpression", 12);
		TraceIn("multiplicativeExpression", 12);
		NCalcParser.multiplicativeExpression_return retval = new NCalcParser.multiplicativeExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal20=null;
		IToken char_literal21=null;
		IToken char_literal22=null;
		NCalcParser.unaryExpression_return left = default(NCalcParser.unaryExpression_return);
		NCalcParser.unaryExpression_return right = default(NCalcParser.unaryExpression_return);

		object char_literal20_tree=null;
		object char_literal21_tree=null;
		object char_literal22_tree=null;


		BinaryExpressionType type = BinaryExpressionType.Unknown;

		try { DebugEnterRule(GrammarFileName, "multiplicativeExpression");
		DebugLocation(181, 1);
		try
		{
			// NCalc.g:185:2: (left= unaryExpression ( ( '*' | '/' | '%' ) right= unaryExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:185:4: left= unaryExpression ( ( '*' | '/' | '%' ) right= unaryExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(185, 8);
			PushFollow(Follow._unaryExpression_in_multiplicativeExpression684);
			left=unaryExpression();
			PopFollow();

			adaptor.AddChild(root_0, left.Tree);
			DebugLocation(185, 25);
			 retval.value = (left!=null?left.value:default(LogicalExpression)); 
			DebugLocation(185, 52);
			// NCalc.g:185:52: ( ( '*' | '/' | '%' ) right= unaryExpression )*
			try { DebugEnterSubRule(16);
			while (true)
			{
				int alt16=2;
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_0 = input.LA(1);

				if (((LA16_0>=40 && LA16_0<=42)))
				{
					alt16=1;
				}


				} finally { DebugExitDecision(16); }
				switch ( alt16 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:186:4: ( '*' | '/' | '%' ) right= unaryExpression
					{
					DebugLocation(186, 4);
					// NCalc.g:186:4: ( '*' | '/' | '%' )
					int alt15=3;
					try { DebugEnterSubRule(15);
					try { DebugEnterDecision(15, decisionCanBacktrack[15]);
					switch (input.LA(1))
					{
					case 40:
						{
						alt15=1;
						}
						break;
					case 41:
						{
						alt15=2;
						}
						break;
					case 42:
						{
						alt15=3;
						}
						break;
					default:
						{
							NoViableAltException nvae = new NoViableAltException("", 15, 0, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}

					} finally { DebugExitDecision(15); }
					switch (alt15)
					{
					case 1:
						DebugEnterAlt(1);
						// NCalc.g:186:6: '*'
						{
						DebugLocation(186, 6);
						char_literal20=(IToken)Match(input,40,Follow._40_in_multiplicativeExpression695); 
						char_literal20_tree = (object)adaptor.Create(char_literal20);
						adaptor.AddChild(root_0, char_literal20_tree);

						DebugLocation(186, 10);
						 type = BinaryExpressionType.Times; 

						}
						break;
					case 2:
						DebugEnterAlt(2);
						// NCalc.g:187:6: '/'
						{
						DebugLocation(187, 6);
						char_literal21=(IToken)Match(input,41,Follow._41_in_multiplicativeExpression705); 
						char_literal21_tree = (object)adaptor.Create(char_literal21);
						adaptor.AddChild(root_0, char_literal21_tree);

						DebugLocation(187, 10);
						 type = BinaryExpressionType.Div; 

						}
						break;
					case 3:
						DebugEnterAlt(3);
						// NCalc.g:188:6: '%'
						{
						DebugLocation(188, 6);
						char_literal22=(IToken)Match(input,42,Follow._42_in_multiplicativeExpression715); 
						char_literal22_tree = (object)adaptor.Create(char_literal22);
						adaptor.AddChild(root_0, char_literal22_tree);

						DebugLocation(188, 10);
						 type = BinaryExpressionType.Modulo; 

						}
						break;

					}
					} finally { DebugExitSubRule(15); }

					DebugLocation(189, 9);
					PushFollow(Follow._unaryExpression_in_multiplicativeExpression727);
					right=unaryExpression();
					PopFollow();

					adaptor.AddChild(root_0, right.Tree);
					DebugLocation(189, 26);
					 retval.value = new BinaryExpression(type, retval.value, (right!=null?right.value:default(LogicalExpression))); 

					}
					break;

				default:
					goto loop16;
				}
			}

			loop16:
				;

			} finally { DebugExitSubRule(16); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("multiplicativeExpression", 12);
			LeaveRule("multiplicativeExpression", 12);
			Leave_multiplicativeExpression();
		}
		DebugLocation(191, 1);
		} finally { DebugExitRule(GrammarFileName, "multiplicativeExpression"); }
		return retval;

	}
	// $ANTLR end "multiplicativeExpression"

	public class unaryExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public LogicalExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_unaryExpression();
	partial void Leave_unaryExpression();

	// $ANTLR start "unaryExpression"
	// NCalc.g:194:1: unaryExpression returns [LogicalExpression value] : ( primaryExpression | ( '!' | 'not' ) primaryExpression | ( '~' ) primaryExpression | '-' primaryExpression );
	[GrammarRule("unaryExpression")]
	private NCalcParser.unaryExpression_return unaryExpression()
	{
		Enter_unaryExpression();
		EnterRule("unaryExpression", 13);
		TraceIn("unaryExpression", 13);
		NCalcParser.unaryExpression_return retval = new NCalcParser.unaryExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken set24=null;
		IToken char_literal26=null;
		IToken char_literal28=null;
		NCalcParser.primaryExpression_return primaryExpression23 = default(NCalcParser.primaryExpression_return);
		NCalcParser.primaryExpression_return primaryExpression25 = default(NCalcParser.primaryExpression_return);
		NCalcParser.primaryExpression_return primaryExpression27 = default(NCalcParser.primaryExpression_return);
		NCalcParser.primaryExpression_return primaryExpression29 = default(NCalcParser.primaryExpression_return);

		object set24_tree=null;
		object char_literal26_tree=null;
		object char_literal28_tree=null;

		try { DebugEnterRule(GrammarFileName, "unaryExpression");
		DebugLocation(194, 4);
		try
		{
			// NCalc.g:195:2: ( primaryExpression | ( '!' | 'not' ) primaryExpression | ( '~' ) primaryExpression | '-' primaryExpression )
			int alt17=4;
			try { DebugEnterDecision(17, decisionCanBacktrack[17]);
			switch (input.LA(1))
			{
			case INTEGER:
			case FLOAT:
			case STRING:
			case DATETIME:
			case TRUE:
			case FALSE:
			case ID:
			case NAME:
			case 46:
				{
				alt17=1;
				}
				break;
			case 43:
			case 44:
				{
				alt17=2;
				}
				break;
			case 45:
				{
				alt17=3;
				}
				break;
			case 39:
				{
				alt17=4;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 17, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(17); }
			switch (alt17)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:195:4: primaryExpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(195, 4);
				PushFollow(Follow._primaryExpression_in_unaryExpression754);
				primaryExpression23=primaryExpression();
				PopFollow();

				adaptor.AddChild(root_0, primaryExpression23.Tree);
				DebugLocation(195, 22);
				 retval.value = (primaryExpression23!=null?primaryExpression23.value:default(LogicalExpression)); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// NCalc.g:196:8: ( '!' | 'not' ) primaryExpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(196, 8);
				set24=(IToken)input.LT(1);
				if ((input.LA(1)>=43 && input.LA(1)<=44))
				{
					input.Consume();
					adaptor.AddChild(root_0, (object)adaptor.Create(set24));
					state.errorRecovery=false;
				}
				else
				{
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(196, 22);
				PushFollow(Follow._primaryExpression_in_unaryExpression773);
				primaryExpression25=primaryExpression();
				PopFollow();

				adaptor.AddChild(root_0, primaryExpression25.Tree);
				DebugLocation(196, 40);
				 retval.value = new UnaryExpression(UnaryExpressionType.Not, (primaryExpression25!=null?primaryExpression25.value:default(LogicalExpression))); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// NCalc.g:197:8: ( '~' ) primaryExpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(197, 8);
				// NCalc.g:197:8: ( '~' )
				DebugEnterAlt(1);
				// NCalc.g:197:9: '~'
				{
				DebugLocation(197, 9);
				char_literal26=(IToken)Match(input,45,Follow._45_in_unaryExpression785); 
				char_literal26_tree = (object)adaptor.Create(char_literal26);
				adaptor.AddChild(root_0, char_literal26_tree);


				}

				DebugLocation(197, 14);
				PushFollow(Follow._primaryExpression_in_unaryExpression788);
				primaryExpression27=primaryExpression();
				PopFollow();

				adaptor.AddChild(root_0, primaryExpression27.Tree);
				DebugLocation(197, 32);
				 retval.value = new UnaryExpression(UnaryExpressionType.BitwiseNot, (primaryExpression27!=null?primaryExpression27.value:default(LogicalExpression))); 

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// NCalc.g:198:8: '-' primaryExpression
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(198, 8);
				char_literal28=(IToken)Match(input,39,Follow._39_in_unaryExpression799); 
				char_literal28_tree = (object)adaptor.Create(char_literal28);
				adaptor.AddChild(root_0, char_literal28_tree);

				DebugLocation(198, 12);
				PushFollow(Follow._primaryExpression_in_unaryExpression801);
				primaryExpression29=primaryExpression();
				PopFollow();

				adaptor.AddChild(root_0, primaryExpression29.Tree);
				DebugLocation(198, 30);
				 retval.value = new UnaryExpression(UnaryExpressionType.Negate, (primaryExpression29!=null?primaryExpression29.value:default(LogicalExpression))); 

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("unaryExpression", 13);
			LeaveRule("unaryExpression", 13);
			Leave_unaryExpression();
		}
		DebugLocation(199, 4);
		} finally { DebugExitRule(GrammarFileName, "unaryExpression"); }
		return retval;

	}
	// $ANTLR end "unaryExpression"

	public class primaryExpression_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public LogicalExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_primaryExpression();
	partial void Leave_primaryExpression();

	// $ANTLR start "primaryExpression"
	// NCalc.g:201:1: primaryExpression returns [LogicalExpression value] : ( '(' logicalExpression ')' | expr= value | identifier ( arguments )? );
	[GrammarRule("primaryExpression")]
	private NCalcParser.primaryExpression_return primaryExpression()
	{
		Enter_primaryExpression();
		EnterRule("primaryExpression", 14);
		TraceIn("primaryExpression", 14);
		NCalcParser.primaryExpression_return retval = new NCalcParser.primaryExpression_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal30=null;
		IToken char_literal32=null;
		NCalcParser.value_return expr = default(NCalcParser.value_return);
		NCalcParser.logicalExpression_return logicalExpression31 = default(NCalcParser.logicalExpression_return);
		NCalcParser.identifier_return identifier33 = default(NCalcParser.identifier_return);
		NCalcParser.arguments_return arguments34 = default(NCalcParser.arguments_return);

		object char_literal30_tree=null;
		object char_literal32_tree=null;

		try { DebugEnterRule(GrammarFileName, "primaryExpression");
		DebugLocation(201, 1);
		try
		{
			// NCalc.g:202:2: ( '(' logicalExpression ')' | expr= value | identifier ( arguments )? )
			int alt19=3;
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			switch (input.LA(1))
			{
			case 46:
				{
				alt19=1;
				}
				break;
			case INTEGER:
			case FLOAT:
			case STRING:
			case DATETIME:
			case TRUE:
			case FALSE:
				{
				alt19=2;
				}
				break;
			case ID:
			case NAME:
				{
				alt19=3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 19, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(19); }
			switch (alt19)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:202:4: '(' logicalExpression ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(202, 4);
				char_literal30=(IToken)Match(input,46,Follow._46_in_primaryExpression823); 
				char_literal30_tree = (object)adaptor.Create(char_literal30);
				adaptor.AddChild(root_0, char_literal30_tree);

				DebugLocation(202, 8);
				PushFollow(Follow._logicalExpression_in_primaryExpression825);
				logicalExpression31=logicalExpression();
				PopFollow();

				adaptor.AddChild(root_0, logicalExpression31.Tree);
				DebugLocation(202, 26);
				char_literal32=(IToken)Match(input,47,Follow._47_in_primaryExpression827); 
				char_literal32_tree = (object)adaptor.Create(char_literal32);
				adaptor.AddChild(root_0, char_literal32_tree);

				DebugLocation(202, 31);
				 retval.value = (logicalExpression31!=null?logicalExpression31.value:default(LogicalExpression)); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// NCalc.g:203:4: expr= value
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(203, 8);
				PushFollow(Follow._value_in_primaryExpression837);
				expr=value();
				PopFollow();

				adaptor.AddChild(root_0, expr.Tree);
				DebugLocation(203, 16);
				 retval.value = (expr!=null?expr.value:default(ValueExpression)); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// NCalc.g:204:4: identifier ( arguments )?
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(204, 4);
				PushFollow(Follow._identifier_in_primaryExpression845);
				identifier33=identifier();
				PopFollow();

				adaptor.AddChild(root_0, identifier33.Tree);
				DebugLocation(204, 15);
				retval.value = (LogicalExpression) (identifier33!=null?identifier33.value:default(Identifier)); 
				DebugLocation(204, 66);
				// NCalc.g:204:66: ( arguments )?
				int alt18=2;
				try { DebugEnterSubRule(18);
				try { DebugEnterDecision(18, decisionCanBacktrack[18]);
				int LA18_0 = input.LA(1);

				if ((LA18_0==46))
				{
					alt18=1;
				}
				} finally { DebugExitDecision(18); }
				switch (alt18)
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:204:67: arguments
					{
					DebugLocation(204, 67);
					PushFollow(Follow._arguments_in_primaryExpression850);
					arguments34=arguments();
					PopFollow();

					adaptor.AddChild(root_0, arguments34.Tree);
					DebugLocation(204, 77);
					retval.value = new Function((identifier33!=null?identifier33.value:default(Identifier)), ((arguments34!=null?arguments34.value:default(List<LogicalExpression>))).ToArray()); 

					}
					break;

				}
				} finally { DebugExitSubRule(18); }


				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("primaryExpression", 14);
			LeaveRule("primaryExpression", 14);
			Leave_primaryExpression();
		}
		DebugLocation(205, 1);
		} finally { DebugExitRule(GrammarFileName, "primaryExpression"); }
		return retval;

	}
	// $ANTLR end "primaryExpression"

	public class value_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public ValueExpression value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_value();
	partial void Leave_value();

	// $ANTLR start "value"
	// NCalc.g:207:1: value returns [ValueExpression value] : ( INTEGER | FLOAT | STRING | DATETIME | TRUE | FALSE );
	[GrammarRule("value")]
	private NCalcParser.value_return value()
	{
		Enter_value();
		EnterRule("value", 15);
		TraceIn("value", 15);
		NCalcParser.value_return retval = new NCalcParser.value_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken INTEGER35=null;
		IToken FLOAT36=null;
		IToken STRING37=null;
		IToken DATETIME38=null;
		IToken TRUE39=null;
		IToken FALSE40=null;

		object INTEGER35_tree=null;
		object FLOAT36_tree=null;
		object STRING37_tree=null;
		object DATETIME38_tree=null;
		object TRUE39_tree=null;
		object FALSE40_tree=null;

		try { DebugEnterRule(GrammarFileName, "value");
		DebugLocation(207, 1);
		try
		{
			// NCalc.g:208:2: ( INTEGER | FLOAT | STRING | DATETIME | TRUE | FALSE )
			int alt20=6;
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			switch (input.LA(1))
			{
			case INTEGER:
				{
				alt20=1;
				}
				break;
			case FLOAT:
				{
				alt20=2;
				}
				break;
			case STRING:
				{
				alt20=3;
				}
				break;
			case DATETIME:
				{
				alt20=4;
				}
				break;
			case TRUE:
				{
				alt20=5;
				}
				break;
			case FALSE:
				{
				alt20=6;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 20, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(20); }
			switch (alt20)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:208:5: INTEGER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(208, 5);
				INTEGER35=(IToken)Match(input,INTEGER,Follow._INTEGER_in_value870); 
				INTEGER35_tree = (object)adaptor.Create(INTEGER35);
				adaptor.AddChild(root_0, INTEGER35_tree);

				DebugLocation(208, 14);
				 try { retval.value = new ValueExpression(int.Parse((INTEGER35!=null?INTEGER35.Text:null))); } catch(System.OverflowException) { retval.value = new ValueExpression(long.Parse((INTEGER35!=null?INTEGER35.Text:null))); } 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// NCalc.g:209:4: FLOAT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(209, 4);
				FLOAT36=(IToken)Match(input,FLOAT,Follow._FLOAT_in_value878); 
				FLOAT36_tree = (object)adaptor.Create(FLOAT36);
				adaptor.AddChild(root_0, FLOAT36_tree);

				DebugLocation(209, 11);
				 retval.value = new ValueExpression(double.Parse((FLOAT36!=null?FLOAT36.Text:null), NumberStyles.Float, numberFormatInfo)); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// NCalc.g:210:4: STRING
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(210, 4);
				STRING37=(IToken)Match(input,STRING,Follow._STRING_in_value886); 
				STRING37_tree = (object)adaptor.Create(STRING37);
				adaptor.AddChild(root_0, STRING37_tree);

				DebugLocation(210, 12);
				 retval.value = new ValueExpression(extractString((STRING37!=null?STRING37.Text:null))); 

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// NCalc.g:211:5: DATETIME
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(211, 5);
				DATETIME38=(IToken)Match(input,DATETIME,Follow._DATETIME_in_value895); 
				DATETIME38_tree = (object)adaptor.Create(DATETIME38);
				adaptor.AddChild(root_0, DATETIME38_tree);

				DebugLocation(211, 14);
				 retval.value = new ValueExpression(DateTime.Parse((DATETIME38!=null?DATETIME38.Text:null).Substring(1, (DATETIME38!=null?DATETIME38.Text:null).Length-2))); 

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// NCalc.g:212:4: TRUE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(212, 4);
				TRUE39=(IToken)Match(input,TRUE,Follow._TRUE_in_value902); 
				TRUE39_tree = (object)adaptor.Create(TRUE39);
				adaptor.AddChild(root_0, TRUE39_tree);

				DebugLocation(212, 10);
				 retval.value = new ValueExpression(true); 

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// NCalc.g:213:4: FALSE
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(213, 4);
				FALSE40=(IToken)Match(input,FALSE,Follow._FALSE_in_value910); 
				FALSE40_tree = (object)adaptor.Create(FALSE40);
				adaptor.AddChild(root_0, FALSE40_tree);

				DebugLocation(213, 11);
				 retval.value = new ValueExpression(false); 

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("value", 15);
			LeaveRule("value", 15);
			Leave_value();
		}
		DebugLocation(214, 1);
		} finally { DebugExitRule(GrammarFileName, "value"); }
		return retval;

	}
	// $ANTLR end "value"

	public class identifier_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public Identifier value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_identifier();
	partial void Leave_identifier();

	// $ANTLR start "identifier"
	// NCalc.g:216:1: identifier returns [Identifier value] : ( ID | NAME );
	[GrammarRule("identifier")]
	private NCalcParser.identifier_return identifier()
	{
		Enter_identifier();
		EnterRule("identifier", 16);
		TraceIn("identifier", 16);
		NCalcParser.identifier_return retval = new NCalcParser.identifier_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken ID41=null;
		IToken NAME42=null;

		object ID41_tree=null;
		object NAME42_tree=null;

		try { DebugEnterRule(GrammarFileName, "identifier");
		DebugLocation(216, 1);
		try
		{
			// NCalc.g:217:2: ( ID | NAME )
			int alt21=2;
			try { DebugEnterDecision(21, decisionCanBacktrack[21]);
			int LA21_0 = input.LA(1);

			if ((LA21_0==ID))
			{
				alt21=1;
			}
			else if ((LA21_0==NAME))
			{
				alt21=2;
			}
			else
			{
				NoViableAltException nvae = new NoViableAltException("", 21, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(21); }
			switch (alt21)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:217:5: ID
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(217, 5);
				ID41=(IToken)Match(input,ID,Follow._ID_in_identifier928); 
				ID41_tree = (object)adaptor.Create(ID41);
				adaptor.AddChild(root_0, ID41_tree);

				DebugLocation(217, 8);
				 retval.value = new Identifier((ID41!=null?ID41.Text:null)); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// NCalc.g:218:5: NAME
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(218, 5);
				NAME42=(IToken)Match(input,NAME,Follow._NAME_in_identifier936); 
				NAME42_tree = (object)adaptor.Create(NAME42);
				adaptor.AddChild(root_0, NAME42_tree);

				DebugLocation(218, 10);
				 retval.value = new Identifier((NAME42!=null?NAME42.Text:null).Substring(1, (NAME42!=null?NAME42.Text:null).Length-2)); 

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("identifier", 16);
			LeaveRule("identifier", 16);
			Leave_identifier();
		}
		DebugLocation(219, 1);
		} finally { DebugExitRule(GrammarFileName, "identifier"); }
		return retval;

	}
	// $ANTLR end "identifier"

	public class expressionList_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public List<LogicalExpression> value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expressionList();
	partial void Leave_expressionList();

	// $ANTLR start "expressionList"
	// NCalc.g:221:1: expressionList returns [List<LogicalExpression> value] : first= logicalExpression ( ',' follow= logicalExpression )* ;
	[GrammarRule("expressionList")]
	private NCalcParser.expressionList_return expressionList()
	{
		Enter_expressionList();
		EnterRule("expressionList", 17);
		TraceIn("expressionList", 17);
		NCalcParser.expressionList_return retval = new NCalcParser.expressionList_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal43=null;
		NCalcParser.logicalExpression_return first = default(NCalcParser.logicalExpression_return);
		NCalcParser.logicalExpression_return follow = default(NCalcParser.logicalExpression_return);

		object char_literal43_tree=null;


		List<LogicalExpression> expressions = new List<LogicalExpression>();

		try { DebugEnterRule(GrammarFileName, "expressionList");
		DebugLocation(221, 1);
		try
		{
			// NCalc.g:225:2: (first= logicalExpression ( ',' follow= logicalExpression )* )
			DebugEnterAlt(1);
			// NCalc.g:225:4: first= logicalExpression ( ',' follow= logicalExpression )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(225, 9);
			PushFollow(Follow._logicalExpression_in_expressionList960);
			first=logicalExpression();
			PopFollow();

			adaptor.AddChild(root_0, first.Tree);
			DebugLocation(225, 28);
			expressions.Add((first!=null?first.value:default(LogicalExpression)));
			DebugLocation(225, 62);
			// NCalc.g:225:62: ( ',' follow= logicalExpression )*
			try { DebugEnterSubRule(22);
			while (true)
			{
				int alt22=2;
				try { DebugEnterDecision(22, decisionCanBacktrack[22]);
				int LA22_0 = input.LA(1);

				if ((LA22_0==48))
				{
					alt22=1;
				}


				} finally { DebugExitDecision(22); }
				switch ( alt22 )
				{
				case 1:
					DebugEnterAlt(1);
					// NCalc.g:225:64: ',' follow= logicalExpression
					{
					DebugLocation(225, 64);
					char_literal43=(IToken)Match(input,48,Follow._48_in_expressionList967); 
					char_literal43_tree = (object)adaptor.Create(char_literal43);
					adaptor.AddChild(root_0, char_literal43_tree);

					DebugLocation(225, 74);
					PushFollow(Follow._logicalExpression_in_expressionList971);
					follow=logicalExpression();
					PopFollow();

					adaptor.AddChild(root_0, follow.Tree);
					DebugLocation(225, 93);
					expressions.Add((follow!=null?follow.value:default(LogicalExpression)));

					}
					break;

				default:
					goto loop22;
				}
			}

			loop22:
				;

			} finally { DebugExitSubRule(22); }

			DebugLocation(226, 2);
			 retval.value = expressions; 

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expressionList", 17);
			LeaveRule("expressionList", 17);
			Leave_expressionList();
		}
		DebugLocation(227, 1);
		} finally { DebugExitRule(GrammarFileName, "expressionList"); }
		return retval;

	}
	// $ANTLR end "expressionList"

	public class arguments_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		public List<LogicalExpression> value;
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_arguments();
	partial void Leave_arguments();

	// $ANTLR start "arguments"
	// NCalc.g:229:1: arguments returns [List<LogicalExpression> value] : '(' ( expressionList )? ')' ;
	[GrammarRule("arguments")]
	private NCalcParser.arguments_return arguments()
	{
		Enter_arguments();
		EnterRule("arguments", 18);
		TraceIn("arguments", 18);
		NCalcParser.arguments_return retval = new NCalcParser.arguments_return();
		retval.Start = (IToken)input.LT(1);

		object root_0 = null;

		IToken char_literal44=null;
		IToken char_literal46=null;
		NCalcParser.expressionList_return expressionList45 = default(NCalcParser.expressionList_return);

		object char_literal44_tree=null;
		object char_literal46_tree=null;


		retval.value = new List<LogicalExpression>();

		try { DebugEnterRule(GrammarFileName, "arguments");
		DebugLocation(229, 1);
		try
		{
			// NCalc.g:233:2: ( '(' ( expressionList )? ')' )
			DebugEnterAlt(1);
			// NCalc.g:233:4: '(' ( expressionList )? ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(233, 4);
			char_literal44=(IToken)Match(input,46,Follow._46_in_arguments1000); 
			char_literal44_tree = (object)adaptor.Create(char_literal44);
			adaptor.AddChild(root_0, char_literal44_tree);

			DebugLocation(233, 8);
			// NCalc.g:233:8: ( expressionList )?
			int alt23=2;
			try { DebugEnterSubRule(23);
			try { DebugEnterDecision(23, decisionCanBacktrack[23]);
			int LA23_0 = input.LA(1);

			if (((LA23_0>=INTEGER && LA23_0<=NAME)||LA23_0==39||(LA23_0>=43 && LA23_0<=46)))
			{
				alt23=1;
			}
			} finally { DebugExitDecision(23); }
			switch (alt23)
			{
			case 1:
				DebugEnterAlt(1);
				// NCalc.g:233:10: expressionList
				{
				DebugLocation(233, 10);
				PushFollow(Follow._expressionList_in_arguments1004);
				expressionList45=expressionList();
				PopFollow();

				adaptor.AddChild(root_0, expressionList45.Tree);
				DebugLocation(233, 25);
				retval.value = (expressionList45!=null?expressionList45.value:default(List<LogicalExpression>));

				}
				break;

			}
			} finally { DebugExitSubRule(23); }

			DebugLocation(233, 62);
			char_literal46=(IToken)Match(input,47,Follow._47_in_arguments1011); 
			char_literal46_tree = (object)adaptor.Create(char_literal46);
			adaptor.AddChild(root_0, char_literal46_tree);


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("arguments", 18);
			LeaveRule("arguments", 18);
			Leave_arguments();
		}
		DebugLocation(234, 1);
		} finally { DebugExitRule(GrammarFileName, "arguments"); }
		return retval;

	}
	// $ANTLR end "arguments"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _logicalExpression_in_ncalcExpression50 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_ncalcExpression52 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _conditionalExpression_in_logicalExpression72 = new BitSet(new ulong[]{0x80002UL});
		public static readonly BitSet _19_in_logicalExpression78 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _conditionalExpression_in_logicalExpression82 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _20_in_logicalExpression84 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _conditionalExpression_in_logicalExpression88 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _booleanAndExpression_in_conditionalExpression115 = new BitSet(new ulong[]{0x600002UL});
		public static readonly BitSet _set_in_conditionalExpression124 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _conditionalExpression_in_conditionalExpression140 = new BitSet(new ulong[]{0x600002UL});
		public static readonly BitSet _bitwiseOrExpression_in_booleanAndExpression174 = new BitSet(new ulong[]{0x1800002UL});
		public static readonly BitSet _set_in_booleanAndExpression183 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _bitwiseOrExpression_in_booleanAndExpression199 = new BitSet(new ulong[]{0x1800002UL});
		public static readonly BitSet _bitwiseXOrExpression_in_bitwiseOrExpression231 = new BitSet(new ulong[]{0x2000002UL});
		public static readonly BitSet _25_in_bitwiseOrExpression240 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _bitwiseOrExpression_in_bitwiseOrExpression250 = new BitSet(new ulong[]{0x2000002UL});
		public static readonly BitSet _bitwiseAndExpression_in_bitwiseXOrExpression284 = new BitSet(new ulong[]{0x4000002UL});
		public static readonly BitSet _26_in_bitwiseXOrExpression293 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _bitwiseAndExpression_in_bitwiseXOrExpression303 = new BitSet(new ulong[]{0x4000002UL});
		public static readonly BitSet _equalityExpression_in_bitwiseAndExpression335 = new BitSet(new ulong[]{0x8000002UL});
		public static readonly BitSet _27_in_bitwiseAndExpression344 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _equalityExpression_in_bitwiseAndExpression354 = new BitSet(new ulong[]{0x8000002UL});
		public static readonly BitSet _relationalExpression_in_equalityExpression388 = new BitSet(new ulong[]{0xF0000002UL});
		public static readonly BitSet _set_in_equalityExpression399 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _set_in_equalityExpression416 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _relationalExpression_in_equalityExpression435 = new BitSet(new ulong[]{0xF0000002UL});
		public static readonly BitSet _shiftExpression_in_relationalExpression468 = new BitSet(new ulong[]{0xF00000002UL});
		public static readonly BitSet _32_in_relationalExpression479 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _33_in_relationalExpression489 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _34_in_relationalExpression500 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _35_in_relationalExpression510 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _shiftExpression_in_relationalExpression522 = new BitSet(new ulong[]{0xF00000002UL});
		public static readonly BitSet _additiveExpression_in_shiftExpression554 = new BitSet(new ulong[]{0x3000000002UL});
		public static readonly BitSet _36_in_shiftExpression565 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _37_in_shiftExpression575 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _additiveExpression_in_shiftExpression587 = new BitSet(new ulong[]{0x3000000002UL});
		public static readonly BitSet _multiplicativeExpression_in_additiveExpression619 = new BitSet(new ulong[]{0xC000000002UL});
		public static readonly BitSet _38_in_additiveExpression630 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _39_in_additiveExpression640 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _multiplicativeExpression_in_additiveExpression652 = new BitSet(new ulong[]{0xC000000002UL});
		public static readonly BitSet _unaryExpression_in_multiplicativeExpression684 = new BitSet(new ulong[]{0x70000000002UL});
		public static readonly BitSet _40_in_multiplicativeExpression695 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _41_in_multiplicativeExpression705 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _42_in_multiplicativeExpression715 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _unaryExpression_in_multiplicativeExpression727 = new BitSet(new ulong[]{0x70000000002UL});
		public static readonly BitSet _primaryExpression_in_unaryExpression754 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_unaryExpression765 = new BitSet(new ulong[]{0x400000000FF0UL});
		public static readonly BitSet _primaryExpression_in_unaryExpression773 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _45_in_unaryExpression785 = new BitSet(new ulong[]{0x400000000FF0UL});
		public static readonly BitSet _primaryExpression_in_unaryExpression788 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _39_in_unaryExpression799 = new BitSet(new ulong[]{0x400000000FF0UL});
		public static readonly BitSet _primaryExpression_in_unaryExpression801 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _46_in_primaryExpression823 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _logicalExpression_in_primaryExpression825 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _47_in_primaryExpression827 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _value_in_primaryExpression837 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _identifier_in_primaryExpression845 = new BitSet(new ulong[]{0x400000000002UL});
		public static readonly BitSet _arguments_in_primaryExpression850 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _INTEGER_in_value870 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FLOAT_in_value878 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _STRING_in_value886 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _DATETIME_in_value895 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _TRUE_in_value902 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _FALSE_in_value910 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ID_in_identifier928 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NAME_in_identifier936 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _logicalExpression_in_expressionList960 = new BitSet(new ulong[]{0x1000000000002UL});
		public static readonly BitSet _48_in_expressionList967 = new BitSet(new ulong[]{0x788000000FF0UL});
		public static readonly BitSet _logicalExpression_in_expressionList971 = new BitSet(new ulong[]{0x1000000000002UL});
		public static readonly BitSet _46_in_arguments1000 = new BitSet(new ulong[]{0xF88000000FF0UL});
		public static readonly BitSet _expressionList_in_arguments1004 = new BitSet(new ulong[]{0x800000000000UL});
		public static readonly BitSet _47_in_arguments1011 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}
