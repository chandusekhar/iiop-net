/* Generated By:JJTree: Do not edit this line. ASTvalue_base_type.cs */

using System;

namespace parser {

public class ASTvalue_base_type : SimpleNode {
  public ASTvalue_base_type(int id) : base(id) {
  }

  public ASTvalue_base_type(IDLParser p, int id) : base(p, id) {
  }


  /** Accept the visitor. **/
  public override Object jjtAccept(IDLParserVisitor visitor, Object data) {
    return visitor.visit(this, data);
  }
  
  public override string GetIdentification() {
    return "value base";
  }

}


}

