/* Generated By:JJTree: Do not edit this line. ASTinterface_body.cs */

using System;

namespace parser {

public class ASTinterface_body : SimpleNode {
  public ASTinterface_body(int id) : base(id) {
  }

  public ASTinterface_body(IDLParser p, int id) : base(p, id) {
  }


  /** Accept the visitor. **/
  public override Object jjtAccept(IDLParserVisitor visitor, Object data) {
    return visitor.visit(this, data);
  }
}


}

